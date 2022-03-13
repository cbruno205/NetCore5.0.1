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
    public class PersonController: ControllerBase
    {
        private IPersonBusinessService _personBusinessService;
        public PersonController(IPersonBusinessService personBusinessService){
            _personBusinessService = personBusinessService;
        }
        [HttpGet("[action]")]
        public ActionResult GetAll(){
            try{
                return Ok(_personBusinessService.GetAllPersons());
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("[action]")]
        public ActionResult Create (Person person){
            var CreateUser = _personBusinessService.Create(person);
            return Ok(CreateUser);
        }
        [HttpPut("[action]")]
        public ActionResult Update(int id,Person person){
            var UpdateUser = _personBusinessService.Update(id, person);
            return Ok(UpdateUser);
        
        }
        [HttpDelete("[action]")]
        public ActionResult Delete(int id){
            var DeleteUser = _personBusinessService.Delete(id);
            return Ok(DeleteUser);
        }
    }
}