using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Rpg
{
    public class Shop
    {

        public List<Armor> ShopItem_Armor = new List<Armor>()    //상점 방어구
        {
            new Armor("수련자 갑옷",5,"수련에 도움을 주는 갑옷입니다.",1000),
            new Armor("무쇠갑옷",9,"무쇠로 만들어져 튼튼한 갑옷입니다.",2000),
            new Armor("스파르타의 갑옷",15,"스파르타의 전사들이 사용했다는 전설의 갑옷입니다.",3500)
        };

        


        public List<Weapon> ShopItem_Weapon = new List<Weapon>()   //상점 무기
        {
            new Weapon("낡은 검",2,"쉽게 볼 수 있는 낡은 검입니다.",600),
            new Weapon("청동 도끼",5,"어디선가 사용됐던거 같은 도끼입니다.",1500),
            new Weapon("스파르타의 창",7,"스파르타의 전사들이 사용했다는 전설의 창입니다.",4500)


        };

        public void shopInfo()
        {
            Console.Clear();

            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");

            Console.WriteLine();

          

            Console.WriteLine();

            Console.WriteLine("상점 주인: 어서오십쇼 손님 무엇을 하러오셨습니까?");

 
            Console.WriteLine();
           
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Shop_Select();



        }

        public void Shop_Select()
        {
            while (true)
            {
                Console.WriteLine("원하시는 행동을 입력해주세요");
                Console.Write(">>");
                int Select = int.Parse(Console.ReadLine());

                if (Select == 0)
                {
                    Program.SelectMenu();
                }
                else if (Select == 1)
                {
                    Console.Clear();
                    Program.shopBuying();
                }
                else
                {
                    Console.WriteLine("잘못된 선택입니다.");
                }

                
            }
        }
         



}
}
