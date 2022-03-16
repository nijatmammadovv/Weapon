using System;
using Weapon_Task2;

namespace Weapon_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter");
            Console.WriteLine("Enter the bullet capacity");
            int bulletCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of bullets");
            int bulletCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the discharge time of the bullet");
            double dischargeSeconds = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select the shooting mode");
            bool auto = bool.Parse(Console.ReadLine());

            Weapon Gun = new Weapon(bulletCapacity, bulletCount, dischargeSeconds,auto);
            int choise = -1;
            while (choise != 6)
            {
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 0:
                        break;
                    case 1:
                        Gun.Shoot();
                        break;
                    case 2:
                        Gun.Fire();
                        break;
                    case 3:
                        Gun.GetRemainBulletCount();
                        break;
                    case 4:
                        Gun.Reload();
                        break;
                    case 5:
                        Gun.ChangeFireMode();
                        break;
                    case 6:
                        Gun.GetInfo();
                        break;
                    default:
                        Console.WriteLine("Thanks");
                        break;
                }
            }
        }
    }
}