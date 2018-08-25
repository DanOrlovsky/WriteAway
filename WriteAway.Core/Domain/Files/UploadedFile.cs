using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WriteAway.Core.Domain.Files
{
    [Table("UploadedFiles")]
    public class UploadedFile : BaseEntity<int>
    {
        public string FileName { get; set; }

        public string FileLocation { get; set; }

        public string FileDescription { get; set; }

        public int FileTypeId { get; set; }

        public virtual FileType FileType { get; set; }
    }
}
