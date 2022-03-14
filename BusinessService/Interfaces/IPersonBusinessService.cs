using System.Collections.Generic;
using TodoApi.Models;
using TodoApi.ViewModel;

namespace TodoApi.BusinessService.Interfaces
{
    public interface IPersonBusinessService
    {
        List<PersonViewModel> GetAllPersons();
        Person Create (Person person);
        int Delete(int id);
        Person Update (int id, Person person);
    }
}