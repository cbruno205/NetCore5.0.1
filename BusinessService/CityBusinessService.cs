using System.Collections.Generic;
using TodoApi.BusinessService.Interfaces;
using TodoApi.Models;
using TodoApi.DataService.Interfaces;
using TodoApi.ViewModel;
using AutoMapper;

namespace TodoApi.BusinessService
{
    public class CityBusinessService : ICityBusinessService
    {
        private ICityDataService _cityDataService;
        private IMapper _mapper;

        public CityBusinessService (ICityDataService cityDataService, IMapper mapper)
        {   
            _cityDataService = cityDataService;
            _mapper = mapper; 
        }

        public List<CityViewModel> GetAllCities(){
            var cityList = _cityDataService.GetAllCities();
            var cityViewModelList = _mapper.Map<List<CityViewModel>>(cityList);
            return cityViewModelList;
        }

        public City Create(City city){
            var cityCreated = _cityDataService.Create(city);
            return cityCreated;
        }

        public int Delete(int id){
            var cityDeleted = _cityDataService.Delete(id);
            return cityDeleted;
        }

        public City Update (int id, City city){
            var cityUpdated = _cityDataService.Update(id, city);
            return cityUpdated;
        }

    }
}