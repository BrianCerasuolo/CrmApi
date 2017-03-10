using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Crm.Core.Domain;
using Crm.Core.View;

namespace Crm.Services
{
    public class CrmDbContext : DbContext
    {
        public CrmDbContext()
        : base("CrmConn")
        {
            Database.SetInitializer<CrmDbContext>(null);
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }
    }
}
