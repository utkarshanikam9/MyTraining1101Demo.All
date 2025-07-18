using Abp.Domain.Entities.Auditing;
using MyTraining1101Demo.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining1101Demo.Customer
{
    [Table("CustomerUsers")]
    public class CustomerUser:FullAuditedEntity
    {
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual CustomerEntity Customer { get; set; }

        public long UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
