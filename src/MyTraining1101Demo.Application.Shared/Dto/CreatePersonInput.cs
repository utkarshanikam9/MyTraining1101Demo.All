using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyTraining1101Demo.Dto
{
    public class CreatePersonInput
    {
        //public const int MaxNameLength = 32;
        //public const int MaxSurnameLength = 32;
        //public const int MaxEmailAddressLength = 255;

        //DefinedProcessingInstructionProcessor in .core.shared


        [Required]
        [MaxLength(MyTraining1101DemoConsts.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(MyTraining1101DemoConsts.MaxSurnameLength)]
        public string Surname { get; set; }

        [EmailAddress]
        [MaxLength(MyTraining1101DemoConsts.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}
