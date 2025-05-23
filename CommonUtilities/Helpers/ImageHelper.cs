using CommonUtilities.Extensions;
using CommonUtilities.Utility;
using System;
using System.Drawing;
using System.IO;

namespace CommonUtilities.Helpers
{
    public static class ImageHelper
    {
        public static BooleanResult<Image> ImageFromBase64(string base64)
        {
            byte[] imageBytes = Convert.FromBase64String(base64);
            try
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return BooleanResult<Image>.SuccessResult(Image.FromStream(ms));
                }
            }
            catch (Exception e)
            {
                return BooleanResult<Image>.FailResult(e.GetFullMessage());
            }

        }
    }
}
