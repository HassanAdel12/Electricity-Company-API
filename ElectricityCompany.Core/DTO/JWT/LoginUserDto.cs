﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.DTO.JWT
{
    public class LoginUserDto
    {

        [Required, MaxLength(250)]
        [EmailAddress]
        public string Email { get; set; }

        [Required, MaxLength(20)]

        public string Password { get; set; }

    }
}
