using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_gyakorlas_01
{
    internal class Almafa:Fa
    {
       public string nev { get; set; }

       public void kivag()
       {
            Console.WriteLine("Timberrrrrrrrr!");
       }
        
        public string terem()
        {
            return "aLMAAA";
        }
    }
}
