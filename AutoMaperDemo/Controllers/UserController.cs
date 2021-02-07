using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMaperDemo.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AutoMaperDemo.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IMapper Mapper;
        public UserController(IMapper _IMapper)
        {
            Mapper = _IMapper;
        }
        [HttpGet]
        public UserViewModel Index()
        {
            var user = GetUserDetails();

            UserViewModel userViewModel = Mapper.Map<UserViewModel>(user);

            return userViewModel;

        }


        private static User GetUserDetails()
        {
            return new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Email2 = "John.Smith@gmail.com",
                Address = new Address()
                {
                    Country = "US"
                }
            };
        }
    }
}
