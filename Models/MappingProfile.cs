using AutoMapper;
using TodoApi.ViewModel;
namespace TodoApi.Models
{
    public class MappingProfile: Profile
    {
        public MappingProfile(){
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();
            CreateMap<Person, PersonViewModel>();
            CreateMap<PersonViewModel, Person>();
            CreateMap<City, CityViewModel>();
            CreateMap<CityViewModel, City>();
        }
    }

}