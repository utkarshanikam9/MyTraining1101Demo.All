using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTraining1101Demo.CutomerDto
{
    public class CustomerListDto : FullAuditedEntityDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual string EmailId { get; set; }
        public string RegistrationDate { get; set; }
        public string UserName { get; set; }
        //public string UserId { get; set; }
    }
}
