using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries_WinFormToAPI
{
    class Country
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string capital { get; set; }
        public string population { get; set; }
        public string flag { get; set; }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append($"name: {name}\n");
            s.Append($"native-name: {nativeName}\n");
            s.Append($"capital: {capital}\n");
            s.Append($"population: {population}\n");
            s.Append($"flag: {flag}\n");
            return s.ToString();
        }
    }
}
