using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute        
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Check the selected MembershipType
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            // Check if bday is null
            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birthdate is required");
            }

            // Calculate age
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("You need to be at least 18 years old");
        }
    }
}