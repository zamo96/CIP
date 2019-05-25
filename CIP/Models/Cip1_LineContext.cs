using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CIP.Models;

namespace CIP.Models
{
    public class Cip1_LineContext: DbContext
    {
        public DbSet<Cip1_Line> Cip1_Lines { get; set; }
    }
}