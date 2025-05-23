using CommonUtilities.Utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CommonUtilities.Helpers
{
    public static class JObjectHelper
    {
        public static BooleanResult TryParse(string content, out JObject jsonObject)
        {
            jsonObject = null;
            try
            {
                jsonObject = JObject.Parse(content);
                return BooleanResult.DefaultResult;
            }
            catch (JsonReaderException ex)
            {
                return BooleanResult.FailResult($"Error parsing JSON: {ex.Message}");
            }
        }
    }
}
