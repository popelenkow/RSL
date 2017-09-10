using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Globalization;

namespace RSL.Graphics.Validators
{
    public class ValidationNumber : ValidationRule
    {
        public bool IsSigned { get; set; }
        public bool IsPointed { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string text = (string)value;

            ValidationResult ex;

            ex = ValidateSignedness(text);
            if (ex != null) return ex;

            ex = ValidateSign(text);
            if (ex != null) return ex;

            ex = ValidatePoint(text);
            if (ex != null) return ex;

            ex = ValidatePointness(text);
            if (ex != null) return ex;

            return ValidationResult.ValidResult;
        }
        private ValidationResult ValidatePoint(string text)
        {
            if (!IsPointed) return null;

            ResourceDictionary res = Application.Current.Resources;
            ValidationResult ex = new ValidationResult(false, res["ExeptionNumberPointness"]);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    return ex;
                }
            }

            return null;
        }
        private ValidationResult ValidatePointness(string text)
        {
            if (IsPointed) return null;

            ResourceDictionary res = Application.Current.Resources;
            ValidationResult ex = new ValidationResult(false, res["ExeptionNumberPoint"]);
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    count++;
                    if (count > 1)
                    {
                        return ex;
                    }
                }
            }

            return null;
        }
        private ValidationResult ValidateSign(string text)
        {
            if (!IsSigned) return null;

            ResourceDictionary res = Application.Current.Resources;
            ValidationResult ex = new ValidationResult(false, res["ExeptionNumberSing"]);
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == '-')
                {
                    return ex;
                }
            }

            return null;
        }
        private ValidationResult ValidateSignedness(string text)
        {
            if (IsSigned) return null;

            ResourceDictionary res = Application.Current.Resources;
            ValidationResult ex = new ValidationResult(false, res["ExeptionNumberSing"]);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '-')
                {
                    return ex;
                }
            }

            return null;
        }
    }
}
