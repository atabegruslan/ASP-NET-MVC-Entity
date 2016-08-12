using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCEG.Models
{
    public class DictContext:DbContext
    {
        public DbSet<Dict> DictEntries { get; set; }
    }
}