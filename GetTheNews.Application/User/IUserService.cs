using GetTheNews.Domain.Inputs;
using GetTheNews.Domain.Outs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheNews.Application.User
{
    public interface IUserService
    {
        ApiResponse<long> Create(UserInput userInput);
        ApiResponse<List<UserOut>> UserList();
        ApiResponse<UserOut> GetUser(Guid id);
    }
}
