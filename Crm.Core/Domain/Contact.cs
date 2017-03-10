using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crm.Core.Interface;

namespace Crm.Core.Domain
{
    public class Contact : Entity<int>
    {
        public string Guid { get; set; }
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Salutation { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string BusinessNumber { get; set; }
        public string OtherNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Description { get; set; }
        public string CampaignRole { get; set; }
    }
}
