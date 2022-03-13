using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.DataService.Interfaces
{
    public interface IUserDataService
    {
        public List<User> GetAllUser();
        public User Create(User user);
        public int Delete(int id);
        public User Update(int id, User user);

    }
}