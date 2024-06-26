﻿using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dto
{
    public class UserDto
    {
        public UserDto()
        {
            Type = 1;
        }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public int Type { get; set; }
    }
}
