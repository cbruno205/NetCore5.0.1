using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.DataService.Interfaces
{
    public interface ICityDataService
    {
        public List<City> GetAllCities();
        public City Create(City city);
        public int Delete(int id);
        public City Update(int id, City city);

    }
}