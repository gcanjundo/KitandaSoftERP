
using System;
using System.Linq;

namespace KitandaSoftERP.Infra.CrossCutting.Extensions
{
    public static class StringExtensions
    {
        public static string OnlyNumbers(this string pStr)
        {
            if (pStr != null)
            {
                var onlyNumbers = new String(pStr.Where(c => Char.IsDigit(c)).ToArray());
                return onlyNumbers;
            }

            return string.Empty;
        }

        public static string OnlyLetters(this string pStr)
        {
            if (pStr != null)
            {
                var onlyLetters = new String(pStr.Where(c => Char.IsLetter(c)).ToArray());
                return onlyLetters;
            }

            return string.Empty;
        }
    }
}
