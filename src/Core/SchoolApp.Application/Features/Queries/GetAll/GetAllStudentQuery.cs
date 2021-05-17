using AutoMapper;
using MediatR;
using SchoolApp.Application.Dto;
using SchoolApp.Application.Interfaces.Repository;
using SchoolApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolApp.Application.Features.Queries.GetAll
{
    public class GetAllStudentQuery : IRequest<ServiceResponse<List<StudentViewDto>>>
    {
        public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQuery, ServiceResponse<List<StudentViewDto>>>
        {
            private readonly IStudentRepository repository;
            private readonly IMapper mapper;

            public GetAllStudentQueryHandler(IStudentRepository repository, IMapper mapper)
            {
                this.repository = repository;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<List<StudentViewDto>>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
            {
                var students = await repository.GetAllAsync();
                var results = mapper.Map<List<StudentViewDto>>(students);

                return new ServiceResponse<List<StudentViewDto>>(results);
            }
        }
    }
}
