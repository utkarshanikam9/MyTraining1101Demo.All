using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyTraining1101Demo.CutomerDto
{
    public class EditCustomerOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
    }
}
