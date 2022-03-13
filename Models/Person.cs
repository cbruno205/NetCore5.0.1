using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class Person
    {
        [Key]
        public int Id {get; set;}
        public string DNI {get; set;}
        public string Name {get; set;}
        public string LastName{get; set;}
        [ForeignKey("Id")]
        public virtual User IdUser {get; set;}
        [ForeignKey("Id")]
        public virtual City IdCity {get; set;}
    }
}