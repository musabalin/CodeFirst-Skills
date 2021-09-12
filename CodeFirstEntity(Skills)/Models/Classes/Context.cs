using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirstEntity_Skills_.Models.Classes
{
    public class Context:DbContext
    {
        public DbSet<SKILLS> Skills { get; set; }
    }
}