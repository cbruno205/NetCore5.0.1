using System.Collections.Generic;
using TodoApi.BusinessService.Interfaces;
using TodoApi.Models;
using TodoApi.ViewModel;
using TodoApi.DataService.Interfaces;
using AutoMapper;


namespace TodoApi.BusinessService
{
    public class UserBusinessService : IUserBusinessService
    {
        private IUserDataService _userDataService;
        private IMapper _Mapper;

        public UserBusinessService (IUserDataService userDataService, IMapper mapper)
        {   
            _userDataService = userDataService; 
            _Mapper = mapper;
        }

        public List<UserViewModel> GetAllUser(){
            var userList = _userDataService.GetAllUser();
            var UserViewModelsList =_Mapper.Map<List<UserViewModel>>(userList);
            return UserViewModelsList;
        }
    
        public User Create(User user){
            var userCreated = _userDataService.Create(user);
            return userCreated;
        }

        public int Delete(int id){
            var UserDeleted = _userDataService.Delete(id);
            return UserDeleted;
        }

        public User Update (int id, User user){
            var UserModified = _userDataService.Update(id, user);
            return UserModified;
        }

    }
}