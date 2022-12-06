using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Enemy
    {
        public static int _hpGoblin = 3;
        public static int _hpOrc = 5;
        public static int _hpBanshee = 8;

        public static int _GoblinAttackBodySlam = 2;
        public static int _OrcAttackCleave = 3;
        public static int _BansheeAttackScreech = 5;

        public Enemy(int hpGoblin, int hpOrc, int hpBanshee, int GoblinAttackBodySlam, int OrcAttackCleave, int BansheeAttackScreech)
        {
            _hpGoblin = hpGoblin;
            _hpOrc = hpOrc;
            _hpBanshee = hpBanshee;
            _GoblinAttackBodySlam = GoblinAttackBodySlam;
            _OrcAttackCleave = OrcAttackCleave;
            _BansheeAttackScreech = BansheeAttackScreech;
        }
        public static int GoblinLocationX { get; set; }
        public static int GoblinLocationY { get; set; }
        public static int OrcLocationX { get; set; }
        public static int OrcLocationY { get; set; }
        public static int BansheeLocationX { get; set; }
        public static int BansheeLocationY { get; set; }

        public int setGoblinLocationX()
        {
            var location = new Random();
            var enemyLocation = new List<int>();

            for (int n = 0; n <= 5; n++)
            {
                enemyLocation.Add(location.Next(0, 25));
            }
            for (int i = 0; i < enemyLocation.Count; i++)
            {
                GoblinLocationX = enemyLocation[i];
            }
            return GoblinLocationX;
        }
        public int setGoblinLocationY()
        {
            var location = new Random();
            var enemyLocation = new List<int>();

            for (int n = 0; n <= 5; n++)
            {
                enemyLocation.Add(location.Next(0, 25));
            }
            for (int i = 0; i < enemyLocation.Count; i++)
            {
                GoblinLocationY = enemyLocation[i];
            }
            return GoblinLocationY;
        }
        public int setOrcLoctionX()
        {
            var location = new Random();
            var enemyLocation = new List<int>();

            for (int n = 0; n <= 5; n++)
            {
                enemyLocation.Add(location.Next(0, 25));
            }
            for (int i = 0; i < enemyLocation.Count; i++)
            {
                OrcLocationX = enemyLocation[i];
            }
            return OrcLocationX;
        }
        public int setOrcLOcationY()
        {
            var location = new Random();
            var enemyLocation = new List<int>();

            for (int n = 0; n <= 5; n++)
            {
                enemyLocation.Add(location.Next(0, 25));
            }
            for (int i = 0; i < enemyLocation.Count; i++)
            {
                OrcLocationY = enemyLocation[i];
            }
            return OrcLocationY;
        }
        public int setBansheeLocationX()
        {
            var location = new Random();
            var enemyLocation = new List<int>();

            for (int n = 0; n <= 5; n++)
            {
                enemyLocation.Add(location.Next(0, 25));
            }
            for (int i = 0; i < enemyLocation.Count; i++)
            {
                BansheeLocationX = enemyLocation[i];
            }
            return BansheeLocationX;
        }
        public int setBansheeLocationY()
        {
            var location = new Random();
            var enemyLocation = new List<int>();

            for (int n = 0; n <= 5; n++)
            {
                enemyLocation.Add(location.Next(0, 25));
            }
            for (int i = 0; i < enemyLocation.Count; i++)
            {
                BansheeLocationY = enemyLocation[i];
            }
            return BansheeLocationY;
        }

        public static (int, int) GoblinLocation()
        {
            return (GoblinLocationX , GoblinLocationY);
        }
        public static (int, int) BansheeLocation()
        {
            return (BansheeLocationX, BansheeLocationY);
        }
        public static (int, int) OrcLocation()
        {
            return (OrcLocationX, OrcLocationY);
        }
    }
}
