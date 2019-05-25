using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIP.Models
{
    public class Cip1_Line
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }
       public Cip1_Line()
        {

        }
        public Cip1_Line(Cip1_Line cip1_Line)
        {
            this.Id = cip1_Line.Id;
            this.Name = cip1_Line.Name;
            this.Value = cip1_Line.Value;
            this.Date = cip1_Line.Date;
        }
    }
}