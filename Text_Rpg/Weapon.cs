using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Rpg
{
    public class Weapon
    {
        public string name = "" ;

        public int stat;

        public string explain = "";

        public int gold;

        public Weapon(string name, int stat,string explain,int gold)
        {
            this.name = name ;
            this.stat = stat ;
            this.explain = explain ;
            this.gold = gold ;


        }

        public void PrintIt()
        {

            Console.WriteLine($"{name}    | 방어력 + {stat}   |{explain}  |{gold}");


        }


    }
}
