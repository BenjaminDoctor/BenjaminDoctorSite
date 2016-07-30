using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfessionalApp.Models
{
    public class Post
    {
        public int ID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime LastViewDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
    }
}