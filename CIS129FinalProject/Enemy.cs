using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Enemy
    {
        private int _hpGoblin = 3;
        private int _hpOrc = 5;
        private int _hpBanshee = 8;

        private int _GoblinAttackBodySlam = 2;
        private int _OrcAttackCleave = 3;
        private int _BansheeAttackScreech = 5;
        
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
