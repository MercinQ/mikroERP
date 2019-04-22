using AutoMapper;
using mikroERP.API.Dtos;
using mikroERP.API.Models;
using System.Linq;

namespace mikroERP.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
           
            CreateMap<Employee,EmployeeForTableDto>()
            .ForMember(
                dest => dest.NameOfTransport,
                opt => opt.MapFrom(src => src.Transport.NameOfTransport)
            )
            .ForMember(
                dest => dest.NameOfDepartment,
                opt => opt.MapFrom(src => src.Department.NameOfDepartment)
            )
            .ForMember(
                dest => dest.RoomNr,
                opt => opt.MapFrom(src => src.Department.Location.RoomNr)
            )
            .ForMember(
                dest => dest.FloorNr,
                opt => opt.MapFrom(src => src.Department.Location.FloorNr)
            );

            CreateMap<EmployeeForTableDto,Employee>();

        }
    }
}