using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_gyakorlas_01
{
    internal abstract class Gyumolcsfa:Fa
    {
        string gyumolcs;
        public string nev { get; set; }

        public void kivag()
        {
            Console.WriteLine("Bumm!");
        }

        abstract public string terem();
    }
}
