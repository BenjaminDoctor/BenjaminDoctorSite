using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfessionalApp.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ContentTypeID { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}