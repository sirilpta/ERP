using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DAL.Entities
{
    public class AccountCategory
    {
        public int AccountCategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
