using Abp.Domain.Entities.Auditing;
using MyTraining1101Demo.Authorization.Users;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTraining1101Demo.Customer
{
    [Table("Customers")]
    public class CustomerEntity : FullAuditedEntity
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public virtual int CustomerId { get; set; }

        [Required]
        [MaxLength(MyTraining1101DemoConsts.MaxNameLength)]
        public virtual string Name { get; set; }

        [MaxLength(MyTraining1101DemoConsts.MaxaAddressLength)]
        public virtual string Address { get; set; }

        [Required]
        [MaxLength(MyTraining1101DemoConsts.MaxEmailAddressLength)]
        public virtual string EmailId { get; set; }

        public virtual DateTime? RegistrationDate { get; set; } // Optional as per spec

        //[ForeignKey("UserId")]
        //public virtual User User { get; set; }
        //public virtual long UserId { get; set; }

        public virtual ICollection<CustomerUser> CustomerUsers { get; set; }

        //public virtual ICollection<User> Users { get; set; }
    }
}
