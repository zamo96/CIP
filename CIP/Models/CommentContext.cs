using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CIP.Models
{
    public class CommentContext :DbContext
    {
        public DbSet<Comment> Comments { get; set; }
    }
}