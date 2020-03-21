using Mandatory_Umbraco.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.Models;
using Umbraco.Web.PublishedModels;

namespace Mandatory_Umbraco.Controller
{
    public class ProjectsOverviewController : Umbraco.Web.Mvc.RenderMvcController
    {
        // GET: ProjectsOverview
        public override ActionResult Index(ContentModel model)
        {
            ProjectsViewModel viewModel = new ProjectsViewModel(model.Content);

            var projectRadionButtonListDataType = Services.DataTypeService.GetDataType("Project Item - Project Status - Radio button list");
            ValueListConfiguration projectStatusValueList = (ValueListConfiguration)projectRadionButtonListDataType.Configuration;
            List<string> projectStatusList = projectStatusValueList.Items.ConvertAll(input => input.Value.ToString().ToLower());
            viewModel.ProjectStatusList = projectStatusList;

            string projectStatus = "completed";
            viewModel.ProjectStatus = projectStatus;

            IEnumerable<IPublishedContent> projects;
            projects = model.Content.Parent.Children.OfType<ProjectsOverview>().First().Children;

            if (RouteData.Values["status"] != null)
            {
                // urlSegment "project-status"
                projectStatus = RouteData.Values["status"].ToString().ToLower();
                if (!projectStatusList.Contains(projectStatus))
                {
                    throw new HttpException(404, "Not Found");
                }
                viewModel.ProjectStatus = projectStatus;
                projects = projects.Where(
                    x => x.GetProperty("projectStatus")
                    .GetValue().ToString().ToLower() == projectStatus);
            }

            viewModel.Projects = projects.Select(x => (ProjectItem)x).ToList();

            return View("ProjectsOverview", viewModel);
        }
    }
}