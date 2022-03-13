using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.DataService.Interfaces
{
    public interface ILoginDataService
    {
        public User Login(User user);
    }
}