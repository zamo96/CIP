using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using CIP.Models;


namespace CIP.Models
{
    public class PhaseContext : DbContext
    {
        public DbSet<Phase> Phases { get; set; }
   

    }
}