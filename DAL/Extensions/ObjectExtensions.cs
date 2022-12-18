//using Newtonsoft.Json;

//namespace DAL.Extensions
//{
//    public static class ObjectExtensions
//    {
//        public static T FromJson<T>(this string source)
//            where T : class
//        {
//            if (string.IsNullOrWhiteSpace(source))
//            {
//                return null;
//            }

//            return JsonConvert.DeserializeObject<T>(source);
//        }

//        public static string ToJson(this object source)
//        {
//            if (source == null)
//            {
//                return "";
//            }

//            return JsonConvert.SerializeObject(source, new JsonSerializerSettings
//            {
//                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
//            });
//        }
//    }
//}
