using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMaperDemo.Models;
using AutoMaperDemo.ViewModels;
using AutoMapper;
namespace AutoMaperDemo.MappingConfigurations
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            // Default mapping when property names are same

            CreateMap<User, UserViewModel>();

            // Mapping when property names are different
            //CreateMap<User, UserViewModel>()
            //    .ForMember(dest =>
            //    dest.FName,
            //    opt => opt.MapFrom(src => src.FirstName))
            //    .ForMember(dest =>
            //    dest.LName,
            //    opt => opt.MapFrom(src => src.LastName));

            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.Email,
                                opt => opt.MapFrom(src => src.Email2));




            //
            CreateMap<Source, Destination>().IncludeMembers(src => src.Inner);
            CreateMap<Inner, Destination>()
                     .ForMember(dest => dest.InnerValue, opt => opt.MapFrom(src => src.Value));



        }
    }
}
