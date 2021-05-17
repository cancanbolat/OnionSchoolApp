using MediatR;
using SchoolApp.Application.Wrappers;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Features.Commands.Create
{
    public class CreateStudentCommand : IRequest<int>
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime? DateOfBirth { get; set; }

        public int AddressId { get; set; }
        public int CourseId { get; set; }

    }
}
