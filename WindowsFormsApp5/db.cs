using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp5
{
    internal class db:DbContext
    {
        public db() : base("name=constr") { }
        public DbSet<Human> humen { get; set; }
       

    }
}
