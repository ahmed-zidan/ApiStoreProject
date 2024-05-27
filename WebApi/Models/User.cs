﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        
        public string Name { get; set; }
        [Required]
        public byte[] Password { get; set; }
        public byte[] PasswordKey { get; set; }
        
    }
}
