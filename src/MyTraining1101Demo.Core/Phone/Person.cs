using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Castle.Windsor.Configuration.Interpreters.XmlProcessor.ElementProcessors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining1101Demo.Phone
{
    [Table("PbPersons")]
    public class Person : FullAuditedEntity, IMustHaveTenant
    {
        //public const int MaxNameLength = 32;
        //public const int MaxSurnameLength = 32;
        //public const int MaxEmailAddressLength = 255;

        //DefinedProcessingInstructionProcessor in .core.shared

        public virtual int TenantId { get; set; }

        [Required]
        [MaxLength(MyTraining1101DemoConsts.MaxNameLength)]
        public virtual string Name { get; set; }

        [Required]
        [MaxLength(MyTraining1101DemoConsts.MaxSurnameLength)]
        public virtual string Surname { get; set; }

        [MaxLength(MyTraining1101DemoConsts.MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }

        //public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
    }
}