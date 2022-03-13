using System.Collections.Generic;
using TodoApi.BusinessService.Interfaces;
using TodoApi.Models;
using TodoApi.DataService.Interfaces;


namespace TodoApi.BusinessService
{
    public class CityBusinessService : ICityBusinessService
    {
        private ICityDataService _cityDataService;

        public CityBusinessService (ICityDataService cityDataService)
        {   
            _cityDataService = cityDataService; 
        }

        public List<City> GetAllCities(){
            return _cityDataService.GetAllCities();
        }

        public City Create(City city){
            return _cityDataService.Create(city);
        }

        public int Delete(int id){
            return _cityDataService.Delete(id);
        }

        public City Update (int id, City city){
            return _cityDataService.Update(id, city);
        }

    }
}