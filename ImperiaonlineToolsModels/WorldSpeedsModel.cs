using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperiaonlineToolsModels
{
    public class WorldSpeedsModel
    {
        public byte WorldSpeed { get; set; }
        public int MinTime { get; set; }
        public int MinTimeInWar { get; set; }

        public WorldSpeedsModel(string speedModel)
        {
            if (speedModel == "Normal speed")
            {
                this.WorldSpeed = 1;
                this.MinTime = 2400;
                this.MinTimeInWar = 1200;
            }
            else if (speedModel == "Speed x 2")
            {
                this.WorldSpeed = 2;
                this.MinTime = 1200;
                this.MinTimeInWar = 600;
            }
            else if (speedModel == "Speed x 4" || speedModel == "Speed x 10")
            {
                this.WorldSpeed = 4;
                this.MinTime = 600;
                this.MinTimeInWar = 300;
            }
        }
    }
}
