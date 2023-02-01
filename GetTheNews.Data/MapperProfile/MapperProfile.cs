using AutoMapper;
using GetTheNews.Domain.Entities;
using GetTheNews.Domain.Inputs;
using GetTheNews.Domain.Outs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheNews.Data.MapperProfile
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserInput, User>();
            CreateMap<User, UserInput>();

            CreateMap<UserOut, User>();
            CreateMap<User, UserOut>();
        }
    }
}
