using AutoMapper;
using SchoolApp.Application.Dto;
using SchoolApp.Application.Features.Commands.Create;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Mappers
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            //GetAll
            CreateMap<Student, StudentViewDto>().ReverseMap();

            //Get
            CreateMap<Student, GetStudentViewDto>().ReverseMap();

            //Create
            CreateMap<Student, CreateStudentCommand>().ReverseMap();

            //Update

            //Delete
        }
    }
}
