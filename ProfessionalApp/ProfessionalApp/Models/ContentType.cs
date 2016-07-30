using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfessionalApp.Models
{
    public class ContentType
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}