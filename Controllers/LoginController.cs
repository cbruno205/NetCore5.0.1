using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.Models;
using TodoApi.BusinessService.Interfaces;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController :ControllerBase
    {
        private ILoginBusinessService _LoginBusinessService;
        public LoginController(ILoginBusinessService cityBusinessService){
            _LoginBusinessService = cityBusinessService;
        }
        [HttpPost]
        public ActionResult Authentication(User user){
            string token = _LoginBusinessService.Authentication(user);
            if (token == ""){
                return NotFound();
            }
            else{
                return Ok(new{token});
            }
        }
    }
}