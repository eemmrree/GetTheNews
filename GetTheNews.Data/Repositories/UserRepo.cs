using AutoMapper;
using GetTheNews.Data.Context;
using GetTheNews.Domain.Entities;
using GetTheNews.Domain.Inputs;
using GetTheNews.Domain.Interfaces;
using GetTheNews.Domain.Outs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheNews.Data.Repositories
{
    public class UserRepo : GenericRepo<User, UserInput, UserOut>, IUserRepo
    {
        public UserRepo(GetTheNewsContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
