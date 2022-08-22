using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BulletCapasity");
            int BulletCapasity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("BulletCapasity");
           int  BulletCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DischargeSeconds");
            float DischargeSeconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ShootingMode");
            string ShootingMode = Console.ReadLine();

            int choice;
            Weapon gun = new Weapon(BulletCapasity, BulletCount, DischargeSeconds, ShootingMode);
            do

            {
                Console.WriteLine("0) get information ");
                Console.WriteLine("1) Shoot");
                Console.WriteLine("2)Fire");
                Console.WriteLine("3)GetRemainBulletCount");
                Console.WriteLine("4)Reload");
                Console.WriteLine("5) ChangeFireMode");
                Console.WriteLine("6)Exit ");
                Console.WriteLine("7)Edit");
                 
                 choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        gun.GetInfo();
                        break;
                    case 1:
                        gun.Shoot();
                        break;
                    case 2:
                        gun.Fire();
                        break;
                    case 3:
                        gun.GetRemainBulletCount();
                        break;
                    case 4:
                        gun.Reload();
                        break;
                    case 5:
                        gun.ChangeFireMode();
                        break;
                    case 6:
                        break;
                    case 7:
                        Console.WriteLine("if you want to change bulletcapacity, presS T ");
                        Console.WriteLine(" if you want to change bullentcount press S");
                        Console.WriteLine(" if you want to change dischargesecond press D ");
                        char a = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("New Value: ");
                        if (a == 'T') gun.BulletCapasity = Convert.ToInt32(Console.ReadLine());
                        else if (a == 'S') gun.BulletCount = Convert.ToInt32(Console.ReadLine());
                        else if (a == 'D') gun.DischargeSeconds = Convert.ToSingle(Console.ReadLine());
                        break;



                }

            } while (choice != 6);
            
        }
    }
}

