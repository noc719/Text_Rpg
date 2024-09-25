using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Rpg
{
    public class InventoryInput
    {
        public string name = "";

        public int stat ;

        public string explain = "";


        public InventoryInput(string name, int stat, string explain)
        {
            this.name = name;
            this.stat = stat;
            this.explain = explain;
            
        }


        public void PrintIt()
        {
            Console.WriteLine($"{name}    | 방어력 + {stat}   |{explain} ");
        }




    }
}
