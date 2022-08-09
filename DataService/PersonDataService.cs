using System.Collections.Generic;
using TodoApi.Models;
using System.Linq;
using TodoApi.DataService.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace TodoApi.DataService
{
    public class PersonDataService : IPersonDataService
    {
        private GeneralContext _context;
        public PersonDataService (GeneralContext context){
            _context = context;
        }

        public List<Person> GetAllPersons(){
            return _context.Person.ToList();
        }

        public Person Create(Person person){
            _context.Person.Add(person);
            _context.SaveChanges();
            return _context.Person.FirstOrDefault(e =>e.Id == person.Id);
        }
        public Person Update(int id, Person city){
            var _person = _context.Person.FirstOrDefault(e=>e.Id == id);
            _person.DNI = city.DNI;
            _context.Entry(_person).State = EntityState.Modified;
            _context.SaveChanges();
            return _person;
        }
        public int Delete(int id){
            Person person = _context.Person.FirstOrDefault(e=>e.Id == id);
            if (person != null){
                _context.Person.Remove(person);
                _context.SaveChanges();
            }
            return id;
        }
    }

}