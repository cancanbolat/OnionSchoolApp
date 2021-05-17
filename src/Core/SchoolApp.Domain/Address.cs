using System;
using System.Collections.Generic;

#nullable disable

namespace SchoolApp.Domain
{
    public partial class Address
    {
        public Address()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string FullAddress { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
