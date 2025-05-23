using System.Text.RegularExpressions;

namespace CommonUtilities.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNumeric(this string text)
        {
            return Regex.IsMatch(text, @"^-?\d+(\.\d+)?$");
            //return Regex.IsMatch(text, @"^[+-]|\d+(\.\d+)?$");
        }

        public static bool IsNonNumeric(this string input)
        {
            // Return true if any character is not a digit
            //return !input.Any(c => Char.IsDigit(c));
            return Regex.IsMatch(input, @"^[^0-9]*$");
        }
    }
}
