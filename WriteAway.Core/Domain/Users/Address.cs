using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WriteAway.Core.Domain.Users
{
    [Table("Addresses")]
    public class Address : BaseEntity<int>
    {
        public string AddressLine1 { get; set; }        

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }
    }
}
