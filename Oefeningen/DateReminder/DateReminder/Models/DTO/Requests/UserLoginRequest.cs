﻿using System.ComponentModel.DataAnnotations;

namespace DateReminder.Controllers
{
    public class UserLoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}