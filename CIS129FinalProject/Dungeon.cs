using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CIS129FinalProject
{
    internal class Dungeon : Wizert
    {
        public Dungeon(int hpWizert, int mpWizert,
            int hpGoblin, int hpOrc, int hpBanshee,
            int GoblinAttackBodySlam, int OrcAttackCleave,
            int BansheeAttackScreech)
            : base(hpWizert, mpWizert,
                 hpGoblin, hpOrc, hpBanshee,
                 GoblinAttackBodySlam, OrcAttackCleave,
                 BansheeAttackScreech)
        {

        }
        public static bool reachExitLocation()
        {
            bool result = false;
            if (Wizert.playerLocationX == 5 && Wizert.playerLocationY == 5)
            {
                result = true;
            }
            return result;
        }
        public static bool encounterGoblin()
        {
            bool result = false;
            if (Enemy.GoblinLocation() == Wizert.playerLocation())
            {
                result = true;
            }
            return result;
        }
        public static bool encounterBanshee()
        {
            bool result = false;
            if (Enemy.BansheeLocation() == Wizert.playerLocation())
            {
                result = true;
            }
            return result;
        }
        public static bool encounterOrc()
        {
            bool result = false;
            if (Enemy.OrcLocation() == Wizert.playerLocation())
            {
                result = true;
            }
            return result;
        }

        
        public static bool seeHealthPotion()
        {
            bool result = false;
            if (Wizert.HealthPotionLocation() == Wizert.playerLocation())
            {
                result = true;
            }
            return result;
        }
        public static bool seeMagickaPotion()
        {
            bool result = false;
            if (Wizert.MagickaPotionLocation() == Wizert.playerLocation())
            {
                result = true;
            }
            return result;
        }


    }
}
