using System.Collections.Generic;
using TodoApi.BusinessService.Interfaces;
using TodoApi.Models;
using TodoApi.DataService.Interfaces;
using TodoApi.ViewModel;
using AutoMapper;

namespace TodoApi.BusinessService
{
    public class PersonBusinessService : IPersonBusinessService
    {
        private IPersonDataService _personDataService;
        private IMapper _mapper;

        public PersonBusinessService (IPersonDataService personDataService, IMapper mapper)
        {   
            _personDataService = personDataService; 
            _mapper = mapper;
        }

        public List<PersonViewModel> GetAllPersons(){
            var personList = _personDataService.GetAllPersons();
            var personViewModelList = _mapper.Map<List<PersonViewModel>>(personList);
            return personViewModelList;
        }

        public Person Create(Person person){
            var personCreated = _personDataService.Create(person);
            return personCreated;
        }

        public int Delete(int id){
            var personDeleted = _personDataService.Delete(id);
            return personDeleted;
        }

        public Person Update (int id, Person person){
            var personDeleted = _personDataService.Update(id, person);
            return personDeleted;
        }

    }
}