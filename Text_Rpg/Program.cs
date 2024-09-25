using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;

namespace Text_Rpg
{
    internal class Program
    {
        static Character character = new Character();
        static Inventory inventory = new Inventory();
        static Shop shop = new Shop();
        //클래스 가져오기

        static public List<InventoryInput> inventoryInput = new List<InventoryInput>() {};


        static public void Show_item() //인벤토리 아이템 출력
        {
            if (inventoryInput.Count >= 0)
            {
                for (int item = 0; item < inventoryInput.Count; item++)
                {
                    inventoryInput[item].PrintIt();
                }
                    
                Inventory.inventory_Select();
            }
            else
            {
                Console.WriteLine();
                Inventory.inventory_Select();

            }
        }




        static public void Show_item_Management()//장비관리 메뉴
        {
            if (inventoryInput.Count > 0)
            {
                for (int item = 0; item < inventoryInput.Count; item++)
                {
                    inventoryInput[item].PrintIt();
                }
                    

                Console.WriteLine("0. 나가기");

                Console.WriteLine();

                Console.WriteLine("원하시는 행동을 입력해주세요");
                Console.WriteLine(">>");


                while (true)
                {
                    int Select = int.Parse(Console.ReadLine());

                    if (Select == 0)
                    {
                        Console.WriteLine("나가기");
                        Program.SelectMenu();
                    }
                    else if (Select >= 1)
                    {
                        Console.WriteLine("장착되었습니다");
                    }
                    else
                    {
                        Console.WriteLine("다시 입력해주세요");
                    }
                }
            }
            else
            {
                Console.WriteLine("0. 나가기");

                Console.WriteLine();

                Console.WriteLine("원하시는 행동을 입력해주세요");
                Console.WriteLine(">>");

                while (true)
                {
                    int Select = int.Parse(Console.ReadLine());

                    if (Select == 0)
                    {
                        Console.WriteLine("나가기");
                        Program.SelectMenu();
                    }
                }

            }

        }

        static public void inventory_Management() //장비 관리 선택시
        {
            Console.Clear();

            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");

            Console.WriteLine();

            Console.WriteLine("[아이템 목록]");
            Show_item_Management();



        }

        static public void showGold()
        {

        }

        static public void shopBuying() //상점 구매기능 구현
        {


            Console.WriteLine("구매하고 싶은 물품을 선택하여주세요.");
            Console.WriteLine("0. 나가기");
            Console.WriteLine("1. 방어구");
            Console.WriteLine("2. 무기");   //무엇을 살 것인가?

            Console.WriteLine();
            Console.WriteLine("응답을 입력해 주세요");
            Console.Write(">>");

            while (true)
            {
                int Select = int.Parse(Console.ReadLine());

                if (Select == 0)
                {
                    Console.WriteLine("상점을 나갑니다");
                    SelectMenu();
                }
                else if (Select == 1)
                {
                    Console.Clear();
                    BuyArmor();
                }
                else if (Select == 2)
                {
                    Console.Clear();
                    BuyWeapon();
                }


            }


        }


        static public void BuyArmor()  //방어구 구매
        {
            Console.WriteLine("방어구 구매");
            Console.WriteLine();
            for (int i = 0; i < shop.ShopItem_Armor.Count; i++)
            {
                Console.Write("{0}. ", (i + 1));
                shop.ShopItem_Armor[i].PrintIt();


            }

            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            int ArmorCount = shop.ShopItem_Armor.Count - 1;
            

            while (true)
            {
                int item_select = int.Parse(Console.ReadLine()) - 1;

                if (item_select == -1)
                {
                    Console.WriteLine("상점에서 나갑니다.");
                    SelectMenu();
                }
                else if (item_select > -1 && item_select <= ArmorCount)
                {
                    string name = shop.ShopItem_Armor[item_select].name;
                    int stat = shop.ShopItem_Armor[item_select].stat;
                    string explain = shop.ShopItem_Armor[item_select].explain;
                    int gold = shop.ShopItem_Armor[item_select].gold;

                    if (character.gold >= shop.ShopItem_Armor[item_select].gold)
                    {
                        inventoryInput.Add(new InventoryInput(name, stat, explain));
                        character.gold -= shop.ShopItem_Armor[item_select].gold;

                        Console.WriteLine("구매를 완료 하였습니다.");

                    }
                    else
                    {
                        Console.WriteLine("금액이 부족합니다.");

                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }



            }








        }

        static public void BuyWeapon()   //무기구매
        {
            Console.WriteLine("방어구 구매");
            Console.WriteLine();
            for (int i = 0; i < shop.ShopItem_Weapon.Count; i++)
            {
                Console.Write("{0}. ", (i + 1));
                shop.ShopItem_Weapon[i].PrintIt();


            }

            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            int WeaponCount = shop.ShopItem_Weapon.Count - 1;
            

            while (true)
            {
                int item_select = int.Parse(Console.ReadLine()) - 1;

                if (item_select == -1)
                {
                    Console.WriteLine("상점에서 나갑니다.");
                    SelectMenu();
                }
                else if (item_select > -1 && item_select <= WeaponCount)
                {
                    string name = shop.ShopItem_Weapon[item_select].name;
                    int stat = shop.ShopItem_Weapon[item_select].stat;
                    string explain = shop.ShopItem_Weapon[item_select].explain;
                    int gold = shop.ShopItem_Weapon[item_select].gold;

                    if (character.gold >= shop.ShopItem_Weapon[item_select].gold)
                    {
                        inventoryInput.Add(new InventoryInput(name, stat, explain));
                        character.gold -= shop.ShopItem_Weapon[item_select].gold;

                        Console.WriteLine("구매를 완료 하였습니다.");

                    }
                    else
                    {
                        Console.WriteLine("금액이 부족합니다.");

                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }

        }



            static public void SelectMenu()
            {
                Console.Clear();
                Console.WriteLine($"환영합니다 {character.Name}. 던전으로 들어가기전에 활동을 할 수 있습니다.");

                Console.WriteLine();

                Console.WriteLine("1. 상태보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");

                Console.WriteLine();

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">>");


                while (true)
                {
                    int Select = int.Parse(Console.ReadLine());

                    switch (Select)
                    {
                        case 1:

                            Console.WriteLine("상태보기를 선택하셨습니다");
                            character.CharacterInfo();
                            break;
                        case 2:
                            Console.WriteLine("인벤토리를 선택하셨습니다");
                            inventory.inventoryInfo();
                            break;
                        case 3:
                            Console.WriteLine("상점을 선택하셨습니다");
                            shop.shopInfo();
                            break;
                        default:
                            Console.WriteLine("잘못된 입력입니다.");
                            continue;

                    }
                }
            }

        



            static void Main(string[] args)
            {

                Console.WriteLine("마을에 오신 여러분 환영합니다.");

                Console.WriteLine("우선 당신의 이름을 알아야겠네요. 당신의 이름을 알려주세요.");
                Console.Write("당신의 이름은? :");
                character.Name = Console.ReadLine();
                SelectMenu();





            }
        
    }
}
