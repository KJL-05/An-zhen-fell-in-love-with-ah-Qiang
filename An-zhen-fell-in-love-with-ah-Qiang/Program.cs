using System;
using System.Dynamic;
using System.Xml;

namespace An_zhen_fell_in_love_with_ah_Qiang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartAnadventure();
        }

        static void StartAnadventure()
        {
            Console.WriteLine("你是一位冒险者，你一直喜欢这村子里的阿珍。但是在一个漆黑的夜晚，阿珍被一只怪物抓走了，你决定去救她");
            People abc = new People();
            string x;
            Console.WriteLine("Please enter your name");
            x= Console.ReadLine();
            abc.Name = x;
            Console.Write("Your name is:");
            Console.WriteLine(x);
            Monster asd = new Monster();
            Console.WriteLine("Found a monster");
            Console.WriteLine("This monster captured 阿珍");
            Console.WriteLine("Attack or not attack");
            while (abc.Lifelevel > 0 && asd.LifeOfMonster > 0)
            {
                Console.WriteLine("'Y'attack  'N'not attack");
                string Input=Console.ReadLine();
                if (Input == "Y")
                {
                    abc.Attack(10);
                    asd.LifeOfMonster -= 10;
                    asd.Attack(10);
                    abc.Lifelevel -= 10;
                    Console.Write("你的血量：") ;
                    Console.WriteLine(abc.Lifelevel);
                    Console.Write("怪物的血量:");
                    Console.WriteLine(asd.LifeOfMonster);
                    if (asd.LifeOfMonster <= 0)
                    {
                        if (abc.Lifelevel > 0)
                        {
                            Console.WriteLine("You fight the victory monster");
                            Console.WriteLine("阿珍爱上了你，你们过上了幸福的生活");
                        break;
                        }
                    }
                    if (asd.LifeOfMonster > 0 )
                    {
                        if ( abc.Lifelevel > 0)
                        {
                        continue;
                        }
                    }
                    if(abc.Lifelevel<=0)
                    {
                        Console.WriteLine("You Lost. You failed to rescue Azhen");
                        Console.WriteLine("BAD ENDING");
                    }
                }
                else
                {
                    Console.WriteLine("You run away.Game Over.");
                    Console.WriteLine("BAD ENDING");
                    break;
                }

            }
            
        }

    }

    class People
    {
        //成员变量

        public int Lifelevel=100;
        public string Name;
        public int power=10;
        //成员方法
        public void Attack(int x)
        {
            
        }
    }
    public class Monster
    {
        //成员变量
        public int LifeOfMonster=50;

        //成员方法
        public void Attack(int a)
        {

        }
    }






}
