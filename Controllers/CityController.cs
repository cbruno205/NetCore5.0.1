using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.Models;
using TodoApi.BusinessService.Interfaces;
using TodoApi.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace TodoApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CityController: ControllerBase
    {
        private ICityBusinessService _cityBusinessService;
        public CityController(ICityBusinessService cityBusinessService){
            _cityBusinessService = cityBusinessService;
        }
        [AllowAnonymous]
        [HttpGet("[action]")]
        public ActionResult <CityViewModel>GetAll(){
            try{
                return Ok(_cityBusinessService.GetAllCities());
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("[action]")]
        public ActionResult Create (City city){
            var CreateCity = _cityBusinessService.Create(city);
            return Ok(CreateCity);
        }
        [HttpPut("[action]")]
        public ActionResult Update(int id,City city){
            var UpdateCity = _cityBusinessService.Update(id, city);
            return Ok(UpdateCity);
        
        }
        [HttpDelete("[action]")]
        public ActionResult Delete(int id){
            var DeleteCity = _cityBusinessService.Delete(id);
            return Ok(DeleteCity);
        }
    }
}