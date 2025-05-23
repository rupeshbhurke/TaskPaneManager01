namespace CommonUtilities.Extensions
{
    public static class IntExtensions
    {
        public static string PadLeft(this int number, int length, char paddingChar = '0')
        {
            var numberStr = number.ToString();
            return numberStr.PadLeft(length, paddingChar);
        }

        public static string PadRight(this int number, int length, char paddingChar = '0')
        {
            var numberStr = number.ToString();
            return numberStr.PadRight(length, paddingChar);
        }

    }

}