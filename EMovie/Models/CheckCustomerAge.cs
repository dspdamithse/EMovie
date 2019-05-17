using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EMovie.Models
{
    public class CheckCustomerAge : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.notselected || customer.MembershipTypeId == MembershipType.freeMembership)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate field must be fill out.");

            var customer_age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (customer_age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Your Age Must Be At Least 19");
        }
    }
}