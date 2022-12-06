﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_WEB_API.Models
{
    public class Login
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter employee id")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Please enter employee id")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
