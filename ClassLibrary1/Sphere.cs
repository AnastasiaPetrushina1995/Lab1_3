using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Sphere : IFigure
    {
        private int _radius;
        public Sphere(int radius)
        {
            _radius = radius;
        }
        public double ReturnVolume()
        {
            return 4 / 3.0 * Math.PI * Math.Pow(_radius, 3);
        }
    }
}
