using System;
using System.Collections.Generic;

using System.Text;

namespace ConsoleApp1.models
{
    class Weapon
    {
        private int _bulletCapasity;
        private int _bulletCount;
        private float _dischargeSeconds;
        private string _shootingMode;



        public int BulletCapasity
        {
            get
            {
                return _bulletCapasity;
            }
            set
            {
                if (value > 0)
                {
                    _bulletCapasity = value;
                }
            }
        }
        public int BulletCount
        {
            get
            {
                return _bulletCount;
            }
            set
            {
                if (value >= 0)
                {
                    _bulletCount = value;
                }


            }

        }
        public float DischargeSeconds
        {
            get
            {
                return _dischargeSeconds;
            }
            set
            {
                if (value > 0)
                {
                    _dischargeSeconds = value;
                }
            }
        }
        public string ShootingMode
        {
            get
            {
                return _shootingMode;
            }
            set
            {
                if (value == "Single" || value == "Auto")
                {
                    _shootingMode = value;
                }
            }
        }
        public void Shoot()
        {
            if (BulletCount > 0)

            {
                BulletCount--;
            }
            Console.WriteLine("shot was fired");
            if (BulletCount == 0)
            {
                Console.WriteLine("the bullet escaped");
            }
        }
        public void Fire()
        {
            if (ShootingMode == "automatic") 
            {
                
                float time = (DischargeSeconds / BulletCapasity) * BulletCount;
                BulletCount = 0;
                Console.WriteLine(time);
            }
           else
            {
                BulletCount--;
            }

        }
        public int GetRemainBulletCount()
        {
            return BulletCapasity - BulletCount;
        }

        public void Reload()
        {
            BulletCount = BulletCapasity;
            Console.WriteLine("Reload");
        }

        public void ChangeFireMode()
        {
            if (ShootingMode == "Single")
            {
                ShootingMode = "Automatic";
            }
            else
            {
                ShootingMode = "Single";
            }
            
        }
        public void GetInfo()
        {
            Console.WriteLine("BulletCapasity:"+ BulletCapasity + "\nBulletCount:"+BulletCount + "\nDischargeSeconds:" + DischargeSeconds +  "\nShootingMode:" +ShootingMode);
        }
        public Weapon(int bulletCapasity, int bulletCount, float dischargeSeconds, string shootingMode)
        {
            BulletCapasity = bulletCapasity;
            BulletCount = bulletCount;
            DischargeSeconds = dischargeSeconds;
            ShootingMode = shootingMode;
        }
       
          

    }


}

    

