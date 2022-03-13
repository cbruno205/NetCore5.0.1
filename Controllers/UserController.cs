using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.Models;
using TodoApi.BusinessService.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace TodoApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        private IUserBusinessService _userBusinessService;
        public UserController(IUserBusinessService userBusinessService){
            _userBusinessService = userBusinessService;
        }
        [HttpGet("[action]")]
        public ActionResult <User>GetAll(){
            try{
                return Ok(_userBusinessService.GetAllUser());
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("[action]")]
        public ActionResult Create (User user){
            var NewUser = _userBusinessService.Create(user);
            return Ok(NewUser);
        }
        [HttpPut("[action]")]
        public ActionResult Update(int id,User user){
            var UserModified = _userBusinessService.Update(id, user);
            return Ok(UserModified);
        
        }
        [HttpDelete("[action]")]
        public ActionResult Delete(int id){
            var DeleteUser = _userBusinessService.Delete(id);
            return Ok(DeleteUser);
        }
    }
}