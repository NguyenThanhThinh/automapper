using AutoMapper;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.Mapping
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<User, UserViewModel>()
			.ForMember(des => des.FName, n => n.MapFrom(k => k.FirstName))

			.ForMember(des => des.LName, t => t.MapFrom(h => h.LastName)).

			ForMember(f => f.FullName, n => n.MapFrom(m => $"{m.LastName} {m.FirstName}"));


		}
	}
}
