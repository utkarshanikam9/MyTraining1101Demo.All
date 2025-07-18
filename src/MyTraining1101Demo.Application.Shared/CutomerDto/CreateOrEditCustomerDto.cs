using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyTraining1101Demo.CutomerDto
{
    public class CreateOrEditCustomerDto
    {
        public int? Id { get; set; } // null when adding

        [Required]
        [StringLength(MyTraining1101DemoConsts.MaxNameLength)]
        public string Name { get; set; }

        [StringLength(MyTraining1101DemoConsts.MaxaAddressLength)]
        public string Address { get; set; }

        [Required]
        [StringLength(MyTraining1101DemoConsts.MaxEmailAddressLength)]
        public string EmailId { get; set; }

        public DateTime? RegistrationDate { get; set; }

        [Required]
        public long UserId { get; set; }
    }
}
