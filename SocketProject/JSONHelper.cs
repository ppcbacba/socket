using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SocketProject
{
 public   class JSONHelper
    {
        public static string EntityToJSON<T>(T x)
        {
            var result = string.Empty;
            try
            {
                result = JsonConvert.SerializeObject(x);
            }
            catch (Exception e)
            {
                result = string.Empty;
            }

            return result;

        }

        public static T JSONToEntity<T>(string json)
        {
            var t = default(T);
            try
            {
                t =(T) JsonConvert.DeserializeObject(json, typeof(T));
            }
            catch (Exception e)
            {
                t = default(T);

            }

            return t;

        }


    }
}
