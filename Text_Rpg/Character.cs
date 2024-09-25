using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Rpg
{
    public class Character
    {
       

        //캐릭터 스테이터스
        public int level { get; set; } = 1;
        public string Name { get; set; }
        public string job { get; set; } = "전사";
        public int atk { get; set; } = 10;
        public int def { get; set; } = 5;
        public int hp { get; set; } = 100;
        public int gold { get; set; } = 1500;





        //캐릭터 정보창
        public void CharacterInfo()
        {
            Console.Clear();

            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");

            Console.WriteLine();

            Console.WriteLine($"LV. 0{level}");
            Console.WriteLine($"{Name} ( {job} )");
            Console.WriteLine($"공격력 : {atk}");
            Console.WriteLine($"방어력 : {def}");
            Console.WriteLine($"체 력 : {hp}");
            Console.WriteLine($"Gold : {gold} G");

            Console.WriteLine();
            CharacterInfo_exit();

        }
        public void CharacterInfo_exit()
        {
            Console.WriteLine("0. 나가기");

            Console.WriteLine();

            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");

            while (true)
            {
                int Select = int.Parse(Console.ReadLine());

                if (Select == 0)
                {
                    Console.WriteLine("나가기");
                    Program.SelectMenu();
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
