using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class OurContext:DbContext
    {
        public  DbSet<Ucenik>Ucenici { get; set; }
    }
}
