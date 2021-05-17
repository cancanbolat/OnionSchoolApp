using AutoMapper;
using MediatR;
using SchoolApp.Application.Interfaces.Repository;
using SchoolApp.Application.Wrappers;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolApp.Application.Features.Commands.Create
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, int>
    {
        private readonly IStudentRepository repository;
        private readonly IMapper mapper;

        public CreateStudentCommandHandler(IStudentRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<int> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = mapper.Map<Student>(request);
            await repository.AddAsync(student);

            return student.Id;
        }
    }
}
