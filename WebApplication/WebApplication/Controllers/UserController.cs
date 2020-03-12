using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class UserController : Controller
    {
		private readonly IMapper _mapper;

		public UserController(IMapper mapper)
		{
			_mapper = mapper;
		}
        public IActionResult Index()
        {
			var user = GetUserDetails();

			UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);

			return View(userViewModel);
			
        }

		private static User GetUserDetails()
		{
			return new User()
			{
				Id = 1,
				FirstName = "Nguyen",
				LastName = "Thinh",
				Email = "thanhthinhcntt@gmail.com",
				
			};
		}
	}
}