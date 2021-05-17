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

namespace SchoolApp.Application.Features.Queries.Get
{
    public class GetStudentQueryHandler : IRequestHandler<GetStudentQuery, ServiceResponse<GetStudentViewDto>>
    {
        private readonly IStudentRepository repository;
        private readonly IMapper mapper;

        public GetStudentQueryHandler(IStudentRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<GetStudentViewDto>> Handle(GetStudentQuery request, CancellationToken cancellationToken)
        {
            var student = await repository.GetAsync(request.Id);
            var result = mapper.Map<GetStudentViewDto>(student);

            return new ServiceResponse<GetStudentViewDto>(result);
        }
    }
}
