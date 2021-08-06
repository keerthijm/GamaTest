using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace FileLoggerService
{
    public class FileContent
    {
        [Required]
        [Range(int.MinValue, int.MaxValue, ErrorMessage = "Invalid Integer")]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }

        [RegularExpression(@"^[a-zA-Z]'?([a-zA-Z]|\.| |-)+$", ErrorMessage = "Invalid Description")]
        [StringLength(266, MinimumLength = 3, ErrorMessage = "Invalid Description")]
        [Required]
        public string Description { get; set; }      
    }
}
