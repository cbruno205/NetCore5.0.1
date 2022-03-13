using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.BusinessService.Interfaces
{
    public interface IPersonBusinessService
    {
        List<Person> GetAllPersons();
        Person Create (Person person);
        int Delete(int id);
        Person Update (int id, Person person);
    }
}