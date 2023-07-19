using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OwnIdentity;

public class User 
{
    [ValidateNever]
    public int Id { get; set; }
    
    [Required]
    [BindProperty]
    [StringLength(320,MinimumLength = 10, ErrorMessage = "Minimum length is 10 characters, maximum length is 320 characters")]
    [DisplayName("Email Address")]
    [RegularExpression(@"([a-zA-Z0-9]+(\.|_)?)+([a-zA-Z0-9]+)@([a-zA-Z0-9]+)((\.)[a-zA-Z]{2,})+", ErrorMessage = "Email does not meet requirements" )]
    public string Email { get; set; } = null!;

    [Required]
    [BindProperty]
    [StringLength(18,MinimumLength = 8, ErrorMessage = "Minimum length is 8 characters, maximum length is 18 characters")]
    [DisplayName("Your Password")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}", ErrorMessage = "Password does not meet requirements")]
    public string Password { get; set; } = null!;
    
    
    [NotMapped]
    [Required]
    [BindProperty]
    [DisplayName("Confirm Password")]
    [Compare("Password", ErrorMessage = "Passwords do not match")]
    public string ConfirmPassword { get; set; } = null!;

}
