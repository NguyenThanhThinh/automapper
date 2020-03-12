using System.Collections.Generic;
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

		public IActionResult ListUser()
		{
			var users = ListUsers();

			var listUsers = _mapper.Map<List<UserViewModel>>(users);

			return View(listUsers);

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

		private static List<User> ListUsers()
		{
			var users = new List<User>();
			
			for (int i = 1; i <= 20; i++)
			{
				users.Add(new User
				{
					Id = i,
					FirstName = $"Thanh {i}",
					LastName = $"Thinh {i}",				
				});
			}
			return users;
		}

	}

}

