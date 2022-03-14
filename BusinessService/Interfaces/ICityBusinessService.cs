using System.Collections.Generic;
using TodoApi.Models;
using TodoApi.ViewModel;

namespace TodoApi.BusinessService.Interfaces
{
    public interface ICityBusinessService
    {
        List<CityViewModel> GetAllCities();
        City Create (City city);
        int Delete(int id);
        City Update (int id, City city);
    }
}