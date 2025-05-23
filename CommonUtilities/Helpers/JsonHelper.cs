using System.Collections.Generic;

namespace CommonUtilities.Helpers
{
    public static class JsonHelper
    {
        public static string ConvertToJson(List<Dictionary<string, string>> records)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(records, Newtonsoft.Json.Formatting.Indented);
        }

    }
}