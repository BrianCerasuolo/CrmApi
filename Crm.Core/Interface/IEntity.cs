using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Interface
{
    public interface IModifiableEntity
    {
        //string Name { get; set; }
        bool IsActive { get; set; }
        int TenantId { get; set; }
    }

    public interface IEntity : IModifiableEntity
    {
        object Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        int CreatedById { get; set; }
        int ModifiedById { get; set; }
        //byte[] Version { get; set; }
        
    }

    public interface IEntity<T> : IEntity
    {
        new T Id { get; set; }
    }
}
