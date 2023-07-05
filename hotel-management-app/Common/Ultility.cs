using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management_app.Common
{
    public static class Ultility
    {
        /// <summary>
        /// Convert object to ByteArrayContent
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static ByteArrayContent GetByteArrayContentFromObject(object obj)
        {
            var objByJson = JsonConvert.SerializeObject(obj);
            var buffer = Encoding.UTF8.GetBytes(objByJson);
            var byteContent = new ByteArrayContent(buffer);
            return byteContent;
        }
    }
}
