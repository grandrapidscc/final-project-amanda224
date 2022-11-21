using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Dungeon : Wizert
    {
        public Dungeon(int hpWizert, int mpWizert,
            int hpGoblin, int hpOrc, int hpBanshee,
            int GoblinAttackBodySlam, int OrcAttackCleave,
            int BansheeAttackScreech)
            :base(hpWizert, mpWizert, 
                 hpGoblin,hpOrc,hpBanshee, 
                 GoblinAttackBodySlam,OrcAttackCleave, 
                 BansheeAttackScreech)
        {

        }

    }
}
