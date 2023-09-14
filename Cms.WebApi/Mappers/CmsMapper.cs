using AutoMapper;
using Cms.WebApi.Cms.Data.Repository.Models;
using Cms.WebApi.DTOs;

namespace CmsWebApi.Mappers
{
    public class CmsMapper : Profile
    {
        public CmsMapper()
        {
            CreateMap<CourseDto, Course>()
                .ReverseMap();
            //CreateMap<Course, CourseDto>();
        }
    }
}
