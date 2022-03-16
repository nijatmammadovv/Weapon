using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon_Task2
{
    class Weapon
    {
        public int bulletCapacity;
        public int bulletCount;
        public double dischargeSeconds;
        public bool auto;


        public Weapon(int bulletCapacity, int bulletCount, double dischargeSeconds, bool auto)
        {
            this.bulletCapacity = bulletCapacity;
            this.bulletCapacity = bulletCount;
            this.dischargeSeconds = dischargeSeconds;
            this.auto = auto;

        }


        public void Shoot()
        {
            if (bulletCount > 0)
            {
                bulletCount--;
                Console.WriteLine("1 bullet was fired");
            }
            else
            {
                Console.WriteLine("no bullet left");
            }
        }
        public void Fire()
        {
            if (bulletCount == 0)
            {
                Console.WriteLine("no bullets");
            }
            else
            {
                double time = bulletCount * dischargeSeconds / bulletCapacity;
                Console.WriteLine(time + "san");
            }
        }

        public void GetRemainBulletCount()
        {
            int required = 0;
            required = bulletCapacity - bulletCount;
            Console.WriteLine("How many bullets are left:" + required);
        }
        public void Reload()
        {
            if (bulletCapacity - bulletCount == 0)
            {
                Console.WriteLine("the comb of the bullet is full");
            }
            else
            {
                Console.WriteLine($"{bulletCapacity - bulletCount}: + n add as many bullets");
            }
        }
        public void ChangeFireMode()
        {
            bool choice = bool.Parse(Console.ReadLine());
            if (choice == true)
            {
                auto = true;
            }
            else if (choice == false)
            {
                Console.WriteLine("There are no bullets in the weapon to make a choice");
            }
            else
            {
                Console.WriteLine("Make one of two choices");
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"bulletCapacity:{bulletCapacity} bulletCount:{bulletCount} dischargeSeconds:{dischargeSeconds} auto:{auto}");
        }
    }

}