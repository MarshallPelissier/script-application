using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace script_application
{
    public class Page
    {
        public Page(int num)
        {
            PageNum = num;
        }
        public List<string> Lines;
        public List<string> Images;
        public int PageNum;
        public string Description;
    }
}
