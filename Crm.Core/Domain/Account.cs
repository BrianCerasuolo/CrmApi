using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Domain
{
    public class Account : Entity<int>
    {
        public string AccountName { get; set; }
        public string CustomerUniqueIdentifier { get; set; }
    }
   
}
