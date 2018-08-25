using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WriteAway.Core.Domain.Files;

namespace WriteAway.Core.Domain.Users
{
    [Table("Users")]
    public class User : BaseEntity<Guid>
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsVerified { get; set; }

        public bool IsActive { get; set; }

        public int LoginAttempts { get; set; }

        public bool IsLockedOut { get; set; }

        public string Bio { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        public string Email { get; set; }

        public int ImageFileId { get; set; }


        public virtual UploadedFile ImageFile { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }

    }
}
