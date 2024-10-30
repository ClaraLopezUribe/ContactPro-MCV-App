using System.ComponentModel.DataAnnotations;
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace ContactPro.Areas.Identity.Pages.Account
{
    public class InputModelBase
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2) and at max {1} characters long", MinimumLength = 2)]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2) and at max {1} characters long", MinimumLength = 2)]
        public string? LastName { get; set; }
    }
}