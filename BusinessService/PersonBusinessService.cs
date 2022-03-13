using System.Collections.Generic;
using TodoApi.BusinessService.Interfaces;
using TodoApi.Models;
using TodoApi.DataService.Interfaces;


namespace TodoApi.BusinessService
{
    public class PersonBusinessService : IPersonBusinessService
    {
        private IPersonDataService _personDataService;

        public PersonBusinessService (IPersonDataService personDataService)
        {   
            _personDataService = personDataService; 
        }

        public List<Person> GetAllPersons(){
            return _personDataService.GetAllPersons();
        }

        public Person Create(Person person){
            return _personDataService.Create(person);
        }

        public int Delete(int id){
            return _personDataService.Delete(id);
        }

        public Person Update (int id, Person person){
            return _personDataService.Update(id, person);
        }

    }
}