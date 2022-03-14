using System.Collections.Generic;
using TodoApi.Models;
using TodoApi.ViewModel;

namespace TodoApi.BusinessService.Interfaces
{
    public interface IUserBusinessService
    {
        List<UserViewModel> GetAllUser();
        User Create (User user);
        int Delete(int id);
        User Update (int id, User user);
    }
}