using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace script_application
{
    public class Line
    {
        public string line;
        public Types type;
        public string character;

        public Line(string l, Types t = null, string c = null)
        {
            line = l;
            type = t;
            character = c;
        }

        public override string ToString()
        {
            if (type != null)
            {
                string output;
                output = line + type.PostLine;
                if (character != null && type.Character)
                {
                    output = character + type.PostCharacter + output;
                }
                output = type.PreLine + output;
                return output;
            }

            return line;
        }
    }

    public class Page
    {
        public Page(int num)
        {
            PageNum = num;
        }
        public List<Line> Lines = new List<Line>();
        public List<string> Images = new List<string>();
        public int PageNum;
        public string Description;
    }
}
