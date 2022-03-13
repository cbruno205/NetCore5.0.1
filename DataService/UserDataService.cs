using System.Collections.Generic;
using TodoApi.Models;
using System.Linq;
using TodoApi.DataService.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace TodoApi.DataService
{
    public class UserDataService : IUserDataService
    {
        private GeneralContext _context;
        public UserDataService (GeneralContext context){
            _context = context;
        }

        public List<User> GetAllUser(){
            return _context.user.ToList();
        }

        public User Create(User user){
            _context.user.Add(user);
            _context.SaveChanges();
            return _context.user.FirstOrDefault(e =>e.Id == user.Id);
        }
        public User Update(int id, User user){
            var _user = _context.user.FirstOrDefault(e=>e.Id == user.Id);
            _user.UserName = user.UserName;
            _user.Password = user.Password;

            _context.Entry(_user).State = EntityState.Modified;
            _context.SaveChanges();
            return _user;
        }
        public int Delete(int id){
            User user = _context.user.FirstOrDefault(e=>e.Id == id);
            if (user != null){
                _context.user.Remove(user);
                _context.SaveChanges();
            }
            return id;
        }
    }

}