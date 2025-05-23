using System;
using System.Drawing;

namespace CommonUtilities.Helpers
{
    public static class ColorsHelper
    {
        public static Color HtmlRgbToColor(string htmlColor)
        {
            int r = Convert.ToInt32(htmlColor.Substring(0, 2), 16);
            int g = Convert.ToInt32(htmlColor.Substring(2, 2), 16);
            int b = Convert.ToInt32(htmlColor.Substring(4, 2), 16);
            return Color.FromArgb(r, g, b);
        }

        public static string ColorToHtmlRgb(Color color, bool hashPrefix = false)
        {
            var prefix = hashPrefix ? "#" : "";
            return $"{prefix}{color.R:X2}{color.G:X2}{color.B:X2}";
        }
        public static string ColorToHtmlBGR(Color color, bool hashPrefix = false)
        {
            var prefix = hashPrefix ? "#" : "";
            return $"{prefix}{color.B:X2}{color.G:X2}{color.R:X2}";
        }

        public static string IntToHtmlRgb(int rgb, bool hashPrefix = false)
        {
            var color = ColorToHtmlBGR(Color.FromArgb(rgb), hashPrefix);
            if (color.ToUpper() == "#6E6F73")
            { }

            return color;
        }

        public static Color ColorFromRgb(int rgb)
        {
            int red = (rgb >> 16) & 0xFF;
            int green = (rgb >> 8) & 0xFF;
            int blue = rgb & 0xFF;
            return Color.FromArgb(red, green, blue);
        }
    }
}
