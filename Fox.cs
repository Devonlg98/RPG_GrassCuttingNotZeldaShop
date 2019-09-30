using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GrassCutting
{
    class Fox : Pet
    {
        int foxUpgrade = 0;
        int foxHunger = 0;
        string foxName;
        public Wolf(int v1, int v2, string v3)
        {
            this.foxupgrade = v1;
            this.foxHunger = v2;
            this.foxName = v3;
        }
    }
}
