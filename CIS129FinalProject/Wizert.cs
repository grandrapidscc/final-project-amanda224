using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Wizert
    {
        public static int _hpWizert = 100;
        public static int _mpWizert = 200;

        public Enemy Enemy;
        public Wizert(int hpWizert,
            int mpWizert, int hpGoblin,
            int hpOrc, int hpBanshee,
            int GoblinAttackBodySlam,
            int OrcAttackCleave,
            int BansheeAttackScreech)
        {
            _hpWizert = hpWizert;
            _mpWizert = mpWizert;

            Enemy = new Enemy(hpGoblin, hpOrc,
                hpBanshee,
                GoblinAttackBodySlam,
                OrcAttackCleave,
                BansheeAttackScreech);
        }
        public static int playerLocationX { get; set; }
        public static int playerLocationY { get; set; }
        public static int HealthPotionLocationX { get; set; }
        public static int HealthPotionLocationY { get; set; }
        public static int MagickaPotionLocationX { get; set; }
        public static int MagickaPotionLocationY { get; set; }

        public int setPlayerLocationX()
        {
            var location = new Random();
            var PlayerLocation = new List<int>();

            for (int n = 0; n <= 25; n++)
            {
                PlayerLocation.Add(location.Next(0, 25));
            }
            for (int i = 0; i < PlayerLocation.Count; i++)
            {
                playerLocationX = PlayerLocation[i];
            }
            return playerLocationX;
        }
        public int setPlayerLocationY()
        {
            var location = new Random();
            var PlayerLocation = new List<int>();

            for (int n = 0; n <= 25; n++)
            {
                PlayerLocation.Add(location.Next(0, 25));
            }
            for (int i = 0; i < PlayerLocation.Count; i++)
            {
                playerLocationY = PlayerLocation[i];
            }
            return playerLocationY;
        }
        public int setHealthPotionLocationX()
        {
            var location = new Random();
            var HealthPotionLocation = new List<int>();

            for (int n = 0; n <= 5; n++)
            {
                HealthPotionLocation.Add(location.Next(0, 25));
            }
            for (int i = 0; i < HealthPotionLocation.Count; i++)
            {
                HealthPotionLocationX = HealthPotionLocation[i];
            }
            return HealthPotionLocationX;
        }
        public int setHealthPotionLocationY()
        {
            var location = new Random();
            var HealthPotionLocation = new List<int>();

            for (int n = 0; n <= 5; n++)
            {
                HealthPotionLocation.Add(location.Next(0, 25));
            }
            for (int i = 0; i < HealthPotionLocation.Count; i++)
            {
                HealthPotionLocationY = HealthPotionLocation[i];
            }
            return HealthPotionLocationY;
        }
        public int setMagickaPotionLocationX()
        {
            var location = new Random();
            var MagickaPotionLocation = new List<int>();

            for (int n = 0; n <= 5; n++)
            {
                MagickaPotionLocation.Add(location.Next(0, 25));
            }
            for (int i = 0; i < MagickaPotionLocation.Count; i++)
            {
                HealthPotionLocationX = MagickaPotionLocation[i];
            }
            return HealthPotionLocationX;
        }
        public int setMagickaPotionLocationY()
        {
            var location = new Random();
            var MagickaPotionLocation = new List<int>();

            for (int n = 0; n <= 5; n++)
            {
                MagickaPotionLocation.Add(location.Next(0, 25));
            }
            for (int i = 0; i < MagickaPotionLocation.Count; i++)
            {
                MagickaPotionLocationY = MagickaPotionLocation[i];
            }
            return MagickaPotionLocationY;
        }

        public static (int, int) playerLocation()
        {
            return (playerLocationX, playerLocationY);
        }
        public static (int, int) HealthPotionLocation()
        {
            return (HealthPotionLocationX, HealthPotionLocationY);
        }
        public static (int, int) MagickaPotionLocation()
        {
            return (MagickaPotionLocationX, MagickaPotionLocationY);
        }

    }
}
