using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangThucAnNhanh.Models
{
    public class DOBDateValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime date;
            bool parsed = DateTime.TryParse(value.ToString(), out date);
            if (!parsed)
                return new ValidationResult("Invalid Date");
            else
            {
                //change below as per requirement
                var min = DateTime.Now.AddYears(-18); //for min 18 age
                var max = DateTime.Now.AddYears(-100); //for max 100 age
                var msg = string.Format("Độ tuổi phải từ 18 tuổi đến 65 tuổi");
                try
                {
                    if (date > min || date < max)
                        return new ValidationResult(msg);
                    else
                        return ValidationResult.Success;
                }
                catch (Exception e)
                {
                    return new ValidationResult(e.Message);
                }
            }

        }
    }
}