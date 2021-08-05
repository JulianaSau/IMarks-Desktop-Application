using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WebApplication1.Models.Validation;

namespace WebApplication1.Models
{
    public class RegisterViewModel
    {
        public bool NoEmailAvailable { get; set; }

        public string Name { get; set; }
        
        [EmailAddress]
        [Display(Name = "Email")]
        [RequiredIf("NoEmailAvailable", false, ErrorMessage = "Primary Email is required")]
        public string Email { get; set; }
    }

  }
