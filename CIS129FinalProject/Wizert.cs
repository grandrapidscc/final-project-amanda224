using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Wizert
    {
        private int _hpWizert;
        private int _mpWizert;

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
    }
}
