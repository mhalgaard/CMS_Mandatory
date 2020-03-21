using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace Mandatory_Umbraco.ViewModels
{
    public class ProjectsViewModel : ContentModel
    {
        public ProjectsViewModel(IPublishedContent content) : base(content)
        {

        }
        public string ProjectStatus { get; set; }
        public IEnumerable<IPublishedContent> Projects { get; set; }
        public IEnumerable<String> ProjectStatusList { get; set; }

    }
}