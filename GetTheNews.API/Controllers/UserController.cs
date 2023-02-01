using AutoMapper;
using GetTheNews.Application.User;
using GetTheNews.Domain.Entities;
using GetTheNews.Domain.Inputs;
using GetTheNews.Domain.Outs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GetTheNews.API.Controllers
{
    [Route("GetTheNews/api/v1/[controller]")]
    [ApiController]

    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class UserController : ControllerBase
    {
        public IUserService UserService;
        public IMapper _mapper;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvertController"/>
        /// </summary>
        /// <param name="advertService">The service<see cref="IAdvertService"/></param>
        /// <param name="fireForgetRepositoryHandler">The service<see cref="IFireForgetHandler"/></param>
        public UserController(IUserService userService , IMapper mapper)
        {
            UserService = userService;
            _mapper = mapper;
        }


        #endregion

        [HttpGet("List")]
        [ProducesResponseType(typeof(ApiResponse<List<UserOut>>), StatusCodes.Status200OK)]
        public ApiResponse<List<UserOut>> UserList()
        {
            return UserService.UserList();
        }

        [HttpGet("Get")]
        [ProducesResponseType(typeof(ApiResponse<UserOut>), StatusCodes.Status200OK)]
        public ApiResponse<UserOut> GetUser(Guid id)
        {
            return UserService.GetUser(id);
        }

        [HttpPost("Create")]
        [ProducesResponseType(typeof(ApiResponse<long>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<long>), StatusCodes.Status404NotFound)]
        public ApiResponse<long> Create([FromBody] UserInput user)
        {
            var response = UserService.Create(user);
            return response;
        }
    }
}
