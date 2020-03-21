using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using Umbraco.Web.Mvc;
using Mandatory_Umbraco.ViewModels;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;

namespace Mandatory_Umbraco.Controller
{
    public class ContactFormSurfaceController : SurfaceController
    {
        // GET: ContactFormSurface
        public ActionResult Index()
        {
            return PartialView("ContactForm", new ContactForm());

        }

        [HttpPost]
        public ActionResult HandleFormSubmit(ContactForm model)
        {
            if (!ModelState.IsValid) { return CurrentUmbracoPage(); }

            MailMessage message = new MailMessage();
            message.To.Add("test@gmail.com");
            message.Subject = model.Subject;
            message.From = new MailAddress(model.Email, model.Name);
            message.Body = model.Message;

            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("thew3zc@gmail.com", "gnwekzejtbxprmbr");

                smtp.Send(message);
            }

            TempData["success"] = true;

            // Get the GuildUdi of ther current page
            GuidUdi currentPageUdi = new GuidUdi(CurrentPage.ContentType.ItemType.ToString(), CurrentPage.Key);

            // Create the new content type
            IContent msg = Services.ContentService.CreateContent(model.Subject, currentPageUdi, "message");
            msg.SetValue("messageName", model.Name);
            msg.SetValue("email", model.Email);
            msg.SetValue("subject", model.Subject);
            msg.SetValue("messageContent", model.Message);
            msg.SetValue("umbracoNaviHide", true);

            // Save
            Services.ContentService.Save(msg);

            return RedirectToCurrentUmbracoPage();

        }
    }
}