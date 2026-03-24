using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPZIZ_PK_New.Features.Helpers;

public class StrongPasswordAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var errors = new StringBuilder();

        var password = value as string;
        if (string.IsNullOrEmpty(password))
            return ValidationResult.Success;

        if (password.Length < 6)
            errors.AppendLine("Пароль должен быть не менее 6 символов; ");
            //return new ValidationResult("Пароль должен быть не менее 6 символов");

        if (!password.Any(char.IsUpper))
            errors.AppendLine("Пароль должен содержать заглавную букву; ");
        //return new ValidationResult(

        if (!password.Any(char.IsDigit))
            errors.AppendLine("Пароль должен содержать цифру");
        //return new ValidationResult(

        //if (!password.Any(char.IsSymbol))
        //    return new ValidationResult("Пароль должен содержать символы");
        if(errors.Length > 0)
            return new ValidationResult(errors.ToString());
        return ValidationResult.Success;
    }
}
