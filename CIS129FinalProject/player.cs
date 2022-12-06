using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public static class Player
    {
        public static void randomLocation()
        {
            var location = new Random();

            var GoblinLocations = new List<int>();
            // Goblin 5 locations
            for (int i = 0; i<= 4; i++ )
            {
                GoblinLocations.Add(location.Next(0, 25));
                
            }

            var OrcLocation = new List<int>();
            // Orc 5 locations
            for (int j = 0; j <= 4; j++)
            {
                OrcLocation.Add(location.Next(0, 25));
                
            }

            var BansheeLocation = new List<int>();
            // Banshee 5 locations
            for (int k = 0; k <= 4; k++)
            {
                BansheeLocation.Add(location.Next(0, 25));
                
            }

            var WizertLocation = new List<int>();
            // Wizert 15 locations
            for (int n = 0; n <= 14; n++)
            {
                WizertLocation.Add(location.Next(0, 25));
                
            }


        }
        public static void encounterEnemy()
        {
            
        }
    }
}
