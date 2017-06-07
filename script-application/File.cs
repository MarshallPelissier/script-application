using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace script_application
{
    public class Files
    {
        public string Project_Name;
        public List<Page> Pages = new List<Page>();
        public List<Types> Types = new List<Types>();
        public List<string> Characters = new List<string>();
        public string Summary;
    }
}
