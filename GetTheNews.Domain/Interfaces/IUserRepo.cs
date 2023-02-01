using GetTheNews.Domain.Entities;
using GetTheNews.Domain.Inputs;
using GetTheNews.Domain.Outs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheNews.Domain.Interfaces
{
    public interface IUserRepo : IGenericRepo<User , UserInput, UserOut>
    {
    }
}
