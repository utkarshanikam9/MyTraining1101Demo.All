using Abp.Application.Services.Dto;
using Microsoft.Graph;
//using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;




namespace MyTraining1101Demo.Dto
{
    public enum PhoneType : byte
    {
        Mobile,
        Home,
        Business
    }

    public class PhoneInPersonListDto : CreationAuditedEntityDto<long>
    {
        public PhoneType Type { get; set; }

        public string Number { get; set; }
    }

}
