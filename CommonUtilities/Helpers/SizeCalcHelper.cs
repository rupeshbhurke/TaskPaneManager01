using System;

namespace CommonUtilities.Helpers
{
    public static class SizeCalcHelper
    {
        public static void CalculateAspectResizedDimensions(float originalWidth, float originalHeight, float targetWidth, float targetHeight, out float newWidth, out float newHeight)
        {
            double widthRatio = (double)targetWidth / originalWidth;
            double heightRatio = (double)targetHeight / originalHeight;

            double minRatio = Math.Min(widthRatio, heightRatio);

            newWidth = (float)(originalWidth * minRatio);
            newHeight = (float)(originalHeight * minRatio);
        }

    }
}