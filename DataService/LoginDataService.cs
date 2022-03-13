using System.Collections.Generic;
using TodoApi.Models;
using System.Linq;
using TodoApi.DataService.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.DataService
{
    public class LoginDataService : ILoginDataService
    {
        private GeneralContext _context;
        public LoginDataService (GeneralContext context){
            _context = context;
        }
        public User Login(User user){
            User user1 = _context.user.FirstOrDefault(e =>e.Id == user.Id);
            if(user1!=null){
                return user1;
            }
            else{
                return null;
            }
        }

    }
}