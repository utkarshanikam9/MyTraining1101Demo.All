using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyTraining1101Demo.Dto
{
    public class AddPhoneInput
    {
        public const int MaxNumberLength = 16;

        [Range(1, int.MaxValue)]
        public int PersonId { get; set; }

        [Required]
        public PhoneType Type { get; set; }

        [Required]
        [MaxLength(MaxNumberLength)]
        public string Number { get; set; }
    }

}
