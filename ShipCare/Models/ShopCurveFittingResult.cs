using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCare.Models
{
    public class ShopCurveFittingResult
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double d { get; set; }
        public double e { get; set; }
    }

    public class ShopCurveFittingArray
    {
        public double Gap { get; set; }
        public double Rpm { get; set; }
    }
}
