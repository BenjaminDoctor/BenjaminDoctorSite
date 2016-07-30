using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProfessionalApp.Models;

namespace ProfessionalApp.DAL
{
    public class ContentInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ContentContext>
    {
        protected override void Seed(ContentContext context)
        {
            var contentTypes = new List<ContentType>
            {
                new ContentType {Name="Blog"},
                new ContentType {Name="Snippet"},
                new ContentType {Name="Link" }
            };

            var categories = new List<Category>
            {
                new Category {Name="Blog"},
                new Category {Name="Snippet"},
                new Category {Name="Link" }
            };

            var posts = new List<Post>
            {
            };
        }
    }
}