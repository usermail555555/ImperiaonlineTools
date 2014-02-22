using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperiaonlineToolsModels
{
    public class CalcInputModel
    {
        public string Speed { get; set; }
        public string ServerTime { get; set; }
        public string TimeToCrash { get; set; }
        public string TimeToEnemy { get; set; }
        public decimal DistanceToEnemy { get; set; }
        public decimal EnemySpeed { get; set; }
        public decimal EnemyCartography { get; set; }
        public decimal EnemyWarHorses { get; set; }
        public decimal ColonyHorses { get; set; }
        public decimal Miracle { get; set; }
        public string InWar { get; set; }
    }
}
