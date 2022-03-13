using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.DataService.Interfaces
{
    public interface IPersonDataService
    {
        public List<Person> GetAllPersons();
        public Person Create(Person person);
        public int Delete(int person);
        public Person Update(int id, Person person);

    }
}