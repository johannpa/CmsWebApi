using AutoMapper;
using Cms.WebApi.Cms.Data.Repository.Models;
using Cms.WebApi.DTOs;
using CmsWebApi.Cms.Data.Repository.Models;
using CmsWebApi.DTOs;

namespace CmsWebApi.Mappers
{
    public class CmsMapper : Profile
    {
        public CmsMapper()
        {
            CreateMap<CourseDto, Course>()
                .ReverseMap();
            //CreateMap<Course, CourseDto>();

            CreateMap<StudentDto, Student>()
                .ReverseMap();
        }
    }
}
