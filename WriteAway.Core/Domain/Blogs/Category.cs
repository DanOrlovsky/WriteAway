using System;
using System.Collections.Generic;
using System.Text;
using WriteAway.Core.Routing;

namespace WriteAway.Core.Domain.Blogs
{
    public class Category : BaseEntity<long>, ISluggable
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public string UrlSlug { get; set; }

        public long? ParentCategoryId { get; set; }

        public void GenerateSlug()
        {
            UrlSlug = Name.CreateNewSlug();
        }
    }
}
