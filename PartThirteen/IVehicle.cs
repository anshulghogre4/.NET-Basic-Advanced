using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartThirteen
{
    internal interface IVehicle
    {
        public int Wheels { get; set; }
        public double Speed { get; set; }

        public void Move();
        public void Stop();

    }
}
