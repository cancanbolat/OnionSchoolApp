using System;
using System.Collections.Generic;

#nullable disable

namespace SchoolApp.Domain
{
    public partial class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? AddressId { get; set; }
        public int? CourseId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Course Course { get; set; }
    }
}
