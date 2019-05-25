using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace CIP.Models
{

    public class GantDiagram
    {
        public double x { get; set; }
        public double x2 { get; set; }
        public int y { get; set; }

        public GantDiagram(double x_value, double x2_value, int y_value)
        {
            x = x_value;
            x2 = x2_value;
            y = y_value;
        }
    }
}