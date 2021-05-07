using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class IndexProject
    {
        public long projectId { get; set; }
        public string projectTitle { get; set; }
        public string projectText { get; set; }
        public string projectCustomer { get; set; }
        public string projectImage { get; set; }

        public IndexProject(long projectId, string projectTitle, string projectText, string projectCustomer, string projectImage)
        {
            this.projectId = projectId;
            this.projectTitle = projectTitle;
            this.projectText = projectText;
            this.projectCustomer = projectCustomer;
            this.projectImage = projectImage;
        }
    }
}
