using CommonUtilities.Extensions;
using CommonUtilities.Utility;
using System;
using System.IO;

namespace CommonUtilities.Helpers
{
    public static class Base64Helper
    {
        public static BooleanResult SaveToFile(string filePath, string base64)
        {
            if (string.IsNullOrWhiteSpace(base64))
            {
                return BooleanResult.FailResult("Base64 string is null or empty.");
            }

            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64);
                File.WriteAllBytes(filePath, imageBytes);
                if (!File.Exists(filePath))
                {
                    return BooleanResult.FailResult(
                        "Failed to write the file to the specified path.");
                }
            }
            catch (Exception e)
            {
                return BooleanResult.FailResult(e.GetFullMessage());
            }
            return BooleanResult.SuccessResult(filePath);
        }

        public static BooleanResult<string> ReadFromFile(string filePath,
            bool deleteAfterRead = false)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                return BooleanResult<string>.FailResult(
                    "The image file path is null or empty.");
            }

            try
            {
                if (!File.Exists(filePath))
                {
                    return BooleanResult<string>.FailResult(
                        "The specified file does not exist.");
                }

                byte[] imageBytes = File.ReadAllBytes(filePath);
                string base64Image = Convert.ToBase64String(imageBytes);

                if (deleteAfterRead)
                {
                    File.Delete(filePath);
                }

                return BooleanResult<string>.SuccessResult(base64Image);
            }
            catch (Exception ex)
            {
                return BooleanResult<string>.FailResult(
                    $"Error while converting file to Base64 string: {ex.GetFullMessage()}");
            }
        }
    }
}
