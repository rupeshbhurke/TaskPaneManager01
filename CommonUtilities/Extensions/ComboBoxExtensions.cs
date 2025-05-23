using System;
using System.Windows.Forms;

namespace CommonUtilities.Extensions
{
    public static class ComboBoxExtensions
    {
        /// <summary>
        /// Gets the selected text of the ComboBox, returning an empty string if:
        /// - The selected index corresponds to a non-data item (e.g., "Select").
        /// - No valid item is selected.
        /// </summary>
        /// <param name="ctl">The ComboBox control.</param>
        /// <param name="firstItemIsDataItem">Indicates whether the first item is a non-data item (e.g., "Select").</param>
        /// <returns>The selected text, or an empty string if no valid item is selected.</returns>
        public static string GetComboText(this ComboBox ctl, bool firstItemIsDataItem = false)
        {
            // Handle null ComboBox or empty items collection
            if (ctl == null || ctl.Items.Count == 0)
                return string.Empty;

            // If the first item is a non-data item, exclude it when checking the selected index
            int nonDataIndex = firstItemIsDataItem ? -1 : 0;

            // Return empty if no valid selection or if the selection matches the non-data index
            if (ctl.SelectedIndex <= nonDataIndex)
                return string.Empty;

            // Return the selected item's text, or empty if null
            return ctl.Items[ctl.SelectedIndex]?.ToString() ?? string.Empty;
        }

        /// <summary>
        /// Sets the selected item in the ComboBox based on the specified text.
        /// If the text is not found, the selection is set to the non-data item (e.g., "Select") if present.
        /// </summary>
        /// <param name="ctl">The ComboBox control.</param>
        /// <param name="text">The text to set as the selected item.</param>
        /// <param name="firstItemIsDataItem">Indicates whether the first item is a non-data item (e.g., "Select").</param>
        public static void SetComboText(this ComboBox ctl, string text, bool firstItemIsDataItem = false)
        {
            // Ensure ComboBox and its items are valid
            if (ctl == null || ctl.Items.Count == 0)
                return;

            // Try to find the item matching the specified text
            int matchingIndex = -1;
            for (int i = firstItemIsDataItem ? 1 : 0; i < ctl.Items.Count; i++)
            {
                if (ctl.Items[i]?.ToString().Equals(text, StringComparison.OrdinalIgnoreCase) == true)
                {
                    matchingIndex = i;
                    break;
                }
            }

            // Set the selected index to the matching item or default to the non-data item
            ctl.SelectedIndex = matchingIndex != -1 ? matchingIndex : (firstItemIsDataItem ? 0 : -1);
        }

        /// <summary>
        /// Sets the selected item in the ComboBox based on an integer value.
        /// </summary>
        /// <param name="ctl">The ComboBox control.</param>
        /// <param name="value">The integer value to set as the selected item.</param>
        /// <param name="firstItemIsDataItem">Indicates whether the first item is a non-data item (e.g., "Select").</param>
        public static void SetComboData(this ComboBox ctl, int value, bool firstItemIsDataItem = false)
        {
            SetComboText(ctl, value.ToString(), firstItemIsDataItem);
        }

        /// <summary>
        /// Sets the selected item in the ComboBox based on a float value.
        /// </summary>
        /// <param name="ctl">The ComboBox control.</param>
        /// <param name="value">The float value to set as the selected item.</param>
        /// <param name="firstItemIsDataItem">Indicates whether the first item is a non-data item (e.g., "Select").</param>
        public static void SetComboData(this ComboBox ctl, float value, bool firstItemIsDataItem = false)
        {
            SetComboText(ctl, value.ToString("G"), firstItemIsDataItem);
        }

        /// <summary>
        /// Sets the selected item in the ComboBox based on a decimal value.
        /// </summary>
        /// <param name="ctl">The ComboBox control.</param>
        /// <param name="value">The decimal value to set as the selected item.</param>
        /// <param name="firstItemIsDataItem">Indicates whether the first item is a non-data item (e.g., "Select").</param>
        public static void SetComboData(this ComboBox ctl, decimal value, bool firstItemIsDataItem = false)
        {
            SetComboText(ctl, value.ToString("G"), firstItemIsDataItem);
        }
    }
}