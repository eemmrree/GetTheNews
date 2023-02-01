using GetTheNews.Domain.Inputs;
using GetTheNews.Domain.Interfaces;
using GetTheNews.Domain.Outs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheNews.Application.User
{
    public class UserService : IUserService
    {
        public IUserRepo UserRepo;

        public UserService(IUserRepo userRepo)
        {
            UserRepo = userRepo;
        }

        public ApiResponse<long> Create(UserInput userInput)
        {
            long id = UserRepo.Add(userInput);
            if (id != -1)
                return new ApiResponse<long>(true, ResultCode.Instance.Ok, 0, 0, "Success", id);
            return new ApiResponse<long>(false, ResultCode.Instance.Failed, 0, 0, "ErrorOccured", -1);
        }

        public ApiResponse<UserOut> GetUser(Guid id)
        {
            var result = UserRepo.FirstOrDefaultAsync(x=>x.Id == id);
            return new ApiResponse<UserOut>(true, ResultCode.Instance.Ok, 0, 0, "Success", result);
        }

        public ApiResponse<List<UserOut>> UserList()
        {
            var result = UserRepo.GetAll();
            return new ApiResponse<List<UserOut>>(true, ResultCode.Instance.Ok, 0, 0, "Success", result);
        }
    }
}
