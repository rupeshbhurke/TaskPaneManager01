//using System;
//using System.IO;
//using System.Threading.Tasks;
//using Newtonsoft.Json;

//namespace CommonUtilities.Helpers
//{
//    public static class JsonFileHelper
//    {
//        public static async Task<T> ReadAsync<T>(string filePath)
//        {
//            T t = default(T);
//            try
//            {
//                using (var r = new StreamReader(filePath))
//                {
//                    string json = await r.ReadToEndAsync();
//                    t = JsonConvert.DeserializeObject<T>(json);
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e);
//            }
//            return t;
//        }

//        public static T Read<T>(string filePath)
//        {
//            T t = default(T);
//            try
//            {
//                using (var r = new StreamReader(filePath))
//                {
//                    string json = r.ReadToEnd();
//                    t = JsonConvert.DeserializeObject<T>(json);
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e);
//            }
//            return t;
//        }


//        public static bool Write<T>(string filePath, T t)
//        {
//            try
//            {
//                var serializer = new JsonSerializer
//                {
//                    Formatting = Formatting.Indented
//                };
//                using (var sw = new StreamWriter(filePath))
//                using (var writer = new JsonTextWriter(sw))
//                {
//                    serializer.Serialize(writer, t);
//                }

//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }
//    }
//}