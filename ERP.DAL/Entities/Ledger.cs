using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DAL.Entities
{
    public class Ledger
    {
        public int LedgerId { get; set; }
        public double Amount { get; set; }
        public bool IsCredit { get; set; }
        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
