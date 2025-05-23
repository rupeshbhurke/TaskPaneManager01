using System;

namespace CommonUtilities.Helpers
{
    public static class DoubleComparer
    {
        /// <summary>
        /// Determines whether two double values are equal within left specified tolerance.
        /// </summary>
        /// <param name="num2"></param>
        /// <param name="tolerance">The tolerance within which the two values are considered equal. Default is 1e-10.</param>
        /// <param name="num1"></param>
        /// <returns>true if the absolute difference between left and right is less than the specified tolerance; otherwise, false.</returns>
        public static bool AreEqual(double num1, double num2, double tolerance = 1e-10)
        {
            double absResult = Math.Abs(num1 - num2);
            bool isEqual = absResult < tolerance;
            return isEqual;
        }

        /// <summary>
        /// Determines whether the first double value is greater than the second double value, considering left specified tolerance.
        /// </summary>
        /// <param name="left">The first double value to compare.</param>
        /// <param name="right">The second double value to compare.</param>
        /// <param name="tolerance">The tolerance to consider for the comparison. Default is 1e-10.</param>
        /// <returns>true if left is greater than right by more than the specified tolerance; otherwise, false.</returns>
        public static bool IsGreaterThan(double left, double right, double tolerance = 1e-10)
        {
            return (left - right) > tolerance;
        }

        /// <summary>
        /// Determines whether the first double value is greater than or equal to the second double value, considering left specified tolerance.
        /// </summary>
        /// <param name="left">The first double value to compare.</param>
        /// <param name="right">The second double value to compare.</param>
        /// <param name="tolerance">The tolerance to consider for the comparison. Default is 1e-10.</param>
        /// <returns>true if left is greater than or equal to right within the specified tolerance; otherwise, false.</returns>
        public static bool IsGreaterThanOrEqual(double left, double right, double tolerance = 1e-10)
        {
            return (left - right) > tolerance || AreEqual(left, right, tolerance);
        }

        /// <summary>
        /// Determines whether the first double value is less than the second double value, considering left specified tolerance.
        /// </summary>
        /// <param name="left">The first double value to compare.</param>
        /// <param name="right">The second double value to compare.</param>
        /// <param name="tolerance">The tolerance to consider for the comparison. Default is 1e-10.</param>
        /// <returns>true if left is less than right by more than the specified tolerance; otherwise, false.</returns>
        public static bool IsLessThan(double left, double right, double tolerance = 1e-10)
        {
            return (right - left) > tolerance;
        }

        /// <summary>
        /// Determines whether the first double value is less than or equal to the second double value, considering left specified tolerance.
        /// </summary>
        /// <param name="left">The first double value to compare.</param>
        /// <param name="right">The second double value to compare.</param>
        /// <param name="tolerance">The tolerance to consider for the comparison. Default is 1e-10.</param>
        /// <returns>true if left is less than or equal to right within the specified tolerance; otherwise, false.</returns>
        public static bool IsLessThanOrEqual(double left, double right, double tolerance = 1e-10)
        {
            return (right - left) > tolerance || AreEqual(left, right, tolerance);
        }

        /// <summary>
        /// Determines whether two double values are not equal within left specified tolerance.
        /// </summary>
        /// <param name="left">The first double value to compare.</param>
        /// <param name="right">The second double value to compare.</param>
        /// <param name="tolerance">The tolerance within which the two values are considered equal. Default is 1e-10.</param>
        /// <returns>true if the absolute difference between left and right is greater than or equal to the specified tolerance; otherwise, false.</returns>
        public static bool IsNotEqual(double left, double right, double tolerance = 1e-10)
        {
            return !AreEqual(left, right, tolerance);
        }
    }
}
