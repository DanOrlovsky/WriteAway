using System;
using System.Collections.Generic;
using System.Text;

namespace WriteAway.Core.Routing
{
    public interface ISluggable
    {
        string UrlSlug { get; set; }

        void GenerateSlug();
    }
}
