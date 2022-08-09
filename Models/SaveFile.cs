using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class SaveFile
    {
        [Key]
        public int Id {get; set;}
        public string Name {get; set;}
        public string Extention {get; set;}
        public double Size {get; set;}
        public string Ubication {get; set;}

    }
}