using System;
using System.Text.RegularExpressions;

namespace Marathone.ViewModel
{
    public static class Sponsor
    {
        public static bool NameIsValid(string name)
        {
            if (string.IsNullOrEmpty(name) == false)
            {
                if (name.Length <= 100)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsCardOwnerNameValid(string cardOwner)
        {
            return new Regex(@"[A-Z]+\s[A-Z]+").IsMatch(cardOwner);
        }

        public static bool CardNumberIsValid(string cardNumber)
        {
            return new Regex(@"[0-9]{4}\s{1}[0-9]{4}\s{1}[0-9]{4}\s{1}[0-9]{4}").IsMatch(cardNumber);
        }

        public static bool Validity(int month, int year)
        {
            if (year == DateTime.Now.Year && month > DateTime.Now.Month || year < DateTime.Now.Year)
                return false;

            return true;
        }
    }
}

