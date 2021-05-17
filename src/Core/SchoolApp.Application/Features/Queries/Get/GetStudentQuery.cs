using MediatR;
using SchoolApp.Application.Dto;
using SchoolApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Features.Queries.Get
{
    public class GetStudentQuery : IRequest<ServiceResponse<GetStudentViewDto>>
    {
        public int Id { get; set; }
    }
}
