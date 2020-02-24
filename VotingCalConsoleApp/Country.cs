using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Country
    {
        public string Name { get; set; }
        public string Vote { get; set; }
        public string Number { get; set; }

        public Country(string n, int N)
        {
            Name = n;
            Vote = "Yes";
            Number = N.ToString();
        }
    }
}
