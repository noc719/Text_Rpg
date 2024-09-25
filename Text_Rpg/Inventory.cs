using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Rpg
{
    public class Inventory
    {
        

        public void inventoryInfo()
        {
            Console.Clear();

            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");

            Console.WriteLine();

            Console.WriteLine("[아이템 목록]");

            Program.Show_item();


            Console.WriteLine();


        }
        static public void inventory_Select()
        {

            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");

            Console.WriteLine();

            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.WriteLine(">>");
            while (true)
            {
                int Select = int.Parse(Console.ReadLine());

                if (Select == 0)
                {

                    Program.SelectMenu();
                }
                else if (Select == 1)
                {
                    Program.inventory_Management();
                }

                else
                {
                    Console.WriteLine("원하시는 행동을 입력해주세요.");
                    Console.Write(">>");
                }
            }
        }

    }
}
