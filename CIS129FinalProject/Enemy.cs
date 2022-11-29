using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Enemy
    {
        private int _hpGoblin;
        private int _hpOrc;
        private int _hpBanshee;

        private int _GoblinAttackBodySlam;
        private int _OrcAttackCleave;
        private int _BansheeAttackScreech;

        public Enemy(int hpGoblin, int hpOrc, int hpBanshee, int GoblinAttackBodySlam, int OrcAttackCleave, int BansheeAttackScreech)
        {
            _hpGoblin = hpGoblin;
            _hpOrc = hpOrc;
            _hpBanshee = hpBanshee;
            _GoblinAttackBodySlam = GoblinAttackBodySlam;
            _OrcAttackCleave = OrcAttackCleave;
            _BansheeAttackScreech = BansheeAttackScreech;
        }

    }
}
