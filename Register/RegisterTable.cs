//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationPage1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class RegisterTable
    {
        public long Account_Number { get; set; }
        [Required(ErrorMessage ="Account Name is required")]
        public string Account_Holdername { get; set; }
        [EmailAddress]
        public string Email_Id { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm_Password { get; set; }
        [Required(ErrorMessage ="Moblie Number is required")]
        public Nullable<long> Mobile_Number { get; set; }
        public string Address { get; set; }
    }
}