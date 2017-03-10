using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<UserClaim> UserClaims { get; set; }

    }
}
