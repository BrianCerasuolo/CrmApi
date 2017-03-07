using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Services
{
    public class CrmDbContext : DbContext
    {
        public CrmDbContext()
        : base("CrmConn")
        {
            Database.SetInitializer<CrmDbContext>(null);
        }
    }
}
