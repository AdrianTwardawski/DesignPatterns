using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public List<Statistics> Statistics { get; set; }

        public void LevelUp()
        {
            Level++;
        }
    }
}
