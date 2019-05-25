using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIP.Models
{
    public class StepDiagram
    {
        public double x { get; set; }
        public int y { get; set; }

        public StepDiagram(double x_value, int y_value)
        {
            x = x_value;

            y = y_value;
        }
    }
}