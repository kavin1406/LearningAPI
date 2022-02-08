using AutoMapper;
using LearningAPI.DataModels;
using dto = LearningWebAPI.DTO;

namespace LearningWebAPI.Profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, dto.Student>()
                .ReverseMap();

            CreateMap<Gender, dto.Gender>()
                .ReverseMap();

            CreateMap<Address, dto.Address>()
                .ReverseMap();


        }
    }
}
