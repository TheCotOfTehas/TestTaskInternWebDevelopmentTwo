using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PointWebDomain
{
    internal class PointWeb
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double Radius { get; set; }
        public string Color { get; set; }
        public List<Сomment> Comments { get; set; }
    }
}
