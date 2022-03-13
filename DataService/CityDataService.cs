using System.Collections.Generic;
using TodoApi.Models;
using System.Linq;
using TodoApi.DataService.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace TodoApi.DataService
{
    public class CityDataService : ICityDataService
    {
        private GeneralContext _context;
        public CityDataService (GeneralContext context){
            _context = context;
        }

        public List<City> GetAllCities(){
            return _context.City.ToList();
        }

        public City Create(City city){
            _context.City.Add(city);
            _context.SaveChanges();
            return _context.City.FirstOrDefault(e =>e.Id == city.Id);
        }
        public City Update(int id, City city){
            var _city = _context.City.FirstOrDefault(e=>e.Id == city.Id);
            _city.Name = city.Name;
            _context.Entry(_city).State = EntityState.Modified;
            _context.SaveChanges();
            return _city;
        }
        public int Delete(int id){
            City city = _context.City.FirstOrDefault(e=>e.Id == id);
            if (city != null){
                _context.City.Remove(city);
                _context.SaveChanges();
            }
            return id;
        }
    }

}