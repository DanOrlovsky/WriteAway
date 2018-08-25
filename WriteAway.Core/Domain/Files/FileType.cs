using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WriteAway.Core.Domain.Files
{

    [Table("AllowedFileTypes")]
    public class FileType : BaseEntity<int>
    {
        public string TypeName { get; set; }

        public string TypeEncoding { get; set; }

        public string TypeExtension { get; set; }
    }
}
