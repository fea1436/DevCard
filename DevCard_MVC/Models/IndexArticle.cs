using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class IndexArticle
    {
        public long articleId { get; set; }
        public string articleTitle { get; set; }
        public string articleSubject { get; set; }
        public string articleImage { get; set; }

        public IndexArticle(long articleId, string articleTitle, string articleSubject, string articleImage)
        {
            this.articleId = articleId;
            this.articleTitle = articleTitle;
            this.articleSubject = articleSubject;
            this.articleImage = articleImage;
        }
    }
}
