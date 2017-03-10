using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crm.Core.Domain;

namespace Crm.Core.View
{
    public class AccountViewModel : Entity<int>
    {
        public string Name { get; set; }
        public string Guid { get; set; }
        public string AccountNumber { get; set; }
        public decimal AnnualRevenue { get; set; }
        public decimal TotalRevenue { get; set; }
        public string Type { get; set; }
        public string LeadStatus { get; set; }
        public string LifecycleStage { get; set; }
        public int OwnerId { get; set; }
        public string Address { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Domain { get; set; }
        public string Description { get; set; }
        public bool DoNotEmail { get; set; }
        public bool DoNotCall { get; set; }
        public bool DoNotSendPostalMail { get; set; }
        public bool DoNotSendMarketingList { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string NumberOfEmployees { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? FirstContactDate { get; set; }
        public DateTime? FirstDealDate { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public DateTime? LastContactedDate { get; set; }
        public DateTime? RecentDealCloseDate { get; set; }
        public decimal RecentDealAmount { get; set; }
    }
}
