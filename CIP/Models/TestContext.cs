﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CIP.Models
{
    public class TestContext:DbContext
    {
        public DbSet<Test> Tests { get; set; }
    }
}