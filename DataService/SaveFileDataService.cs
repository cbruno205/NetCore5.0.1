using System.Collections.Generic;
using TodoApi.Models;
using System.Linq;

namespace TodoApi.DataService
{
    public class SaveFileDataService
    {
        private GeneralContext _context;
        public SaveFileDataService (GeneralContext context){
            _context = context;
        }

        // public List<SaveFile> Get() {
        //     return _context.SaveFile.ToList();
        // }
    }
}