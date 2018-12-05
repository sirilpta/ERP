using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DAL
{
    public class ERPContext:DbContext
    {
        public ERPContext(): base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
