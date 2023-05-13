﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models
{
    public class Student
    {
        [Required]
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Country { get; set; } = default!;
        public List<SelectListItem> Counties { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "PL", Text= "Poland"},
            new SelectListItem { Value = "DE", Text= "Germany"},
            new SelectListItem { Value = "UK", Text= "United Kingdom"},
            new SelectListItem { Value = "US", Text= "United States"},
        };

    }
}
