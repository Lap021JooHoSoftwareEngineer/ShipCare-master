using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCare.Models
{
    public class SeaCurveFittingResult
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
    }

    public class SeaCurverArray
    {
        public double Power { get; set; }
        public double Speed { get; set; }
    }
}
