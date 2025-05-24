using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork.Helpers
{
    public class DifferenceSpot
    {
        public Rectangle Bounds { get; set; }
        public bool Found { get; set; }

        public DifferenceSpot(Rectangle bounds)
        {
            Bounds = bounds;
            Found = false;
        }
    }
}
