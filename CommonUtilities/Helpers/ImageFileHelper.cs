using CommonUtilities.Extensions;
using CommonUtilities.Utility;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CommonUtilities.Helpers
{
    public static class ImageFileHelper
    {
        public static BooleanResult SaveBytesAsImageFile(byte[] imageBytes, string filePath, ImageFormat fmt)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    using (Image image = Image.FromStream(ms))
                    {
                        image.Save(filePath, fmt);
                    }
                }
                return BooleanResult.SuccessResult(filePath);
            }
            catch (Exception e)
            {
                return BooleanResult.FailResult(e.GetFullMessage());
            }
        }

        public static BooleanResult SaveBase64AsImageFile(string base64, string filePath, ImageFormat fmt)
        {
            byte[] imageBytes = Convert.FromBase64String(base64);
            return SaveBytesAsImageFile(imageBytes, filePath, fmt);
        }


        public static BooleanResult<byte[]> GetImageBytes(string imageLocation)
        {
            // Validate the file path
            var validationResult = DirectoryHelper.ValidateFilePath(imageLocation);
            if (!validationResult.Success)
                return BooleanResult<byte[]>.FailResult(validationResult.Message);

            try
            {
                using (Image image = Image.FromFile(imageLocation))
                using (MemoryStream stream = new MemoryStream())
                {
                    image.Save(stream, ImageFormat.Png);
                    return BooleanResult<byte[]>.SuccessResult(stream.ToArray());
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error processing image at {imageLocation}: {ex.Message}";
                return BooleanResult<byte[]>.FailResult(errorMessage);
            }
        }

        public static BooleanResult<string> GetImageAsBase64(string imageLocation)
        {
            // Get the image bytes
            var imageBytesResult = GetImageBytes(imageLocation);
            if (!imageBytesResult.Success)
                return BooleanResult<string>.FailResult(imageBytesResult.Message);

            try
            {
                // Convert byte array to Base64 string
                string base64String = Convert.ToBase64String(imageBytesResult.Result);
                return BooleanResult<string>.SuccessResult(base64String);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error converting image to Base64: {ex.Message}";
                return BooleanResult<string>.FailResult(errorMessage);
            }
        }



    }

}
