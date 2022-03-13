using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.BusinessService.Interfaces
{
    public interface ICityBusinessService
    {
        List<City> GetAllCities();
        City Create (City city);
        int Delete(int id);
        City Update (int id, City city);
    }
}