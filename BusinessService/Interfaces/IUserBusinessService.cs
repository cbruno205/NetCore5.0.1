using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.BusinessService.Interfaces
{
    public interface IUserBusinessService
    {
        List<User> GetAllUser();
        User Create (User user);
        int Delete(int id);
        User Update (int id, User user);
    }
}