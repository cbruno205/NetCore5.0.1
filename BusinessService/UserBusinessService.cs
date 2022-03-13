using System.Collections.Generic;
using TodoApi.BusinessService.Interfaces;
using TodoApi.Models;
using TodoApi.DataService.Interfaces;


namespace TodoApi.BusinessService
{
    public class UserBusinessService : IUserBusinessService
    {
        private IUserDataService _userDataService;

        public UserBusinessService (IUserDataService userDataService)
        {   
            _userDataService = userDataService; 
        }

        public List<User> GetAllUser(){
            return _userDataService.GetAllUser();
        }

        public User Create(User user){
            return _userDataService.Create(user);
        }

        public int Delete(int id){
            return _userDataService.Delete(id);
        }

        public User Update (int id, User user){
            return _userDataService.Update(id, user);
        }

    }
}