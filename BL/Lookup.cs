using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class Lookup
    {
        public string value { get; private set; }
        public string category { get; private set; }

        public Lookup(string Value, string Category)
        {
            value = Value;
            category = Category;
        }
    }
}
