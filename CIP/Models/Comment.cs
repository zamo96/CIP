using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIP.Models
{
    public class Comment
    {
       public int Id { get; set; }
       public string Object { get; set; }
       public int Priority { get; set; }

       public string Commentary { get; set; }
       public DateTime Date { get; set; }
    }
}