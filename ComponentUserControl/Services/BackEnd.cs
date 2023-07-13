using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ComponentUserControl.Services
{
    public class BackEnd
    {
        RestClient client = new RestClient("http://data.gonsa.com.vn/api/product/test");

        /// <summary>
        /// Hàm xử lý lấy danh sách không có điều kiện kèm theo
        /// </summary>
        public List<T> GetCTDHTest<T>()
        {
            //string maChiTiet = "DOTD230505095501307";
            try
            {
                var request = new RestRequest($"http://data.gonsa.com.vn/api/product/getProductForMiddleWare?count=50&pageNums=1", Method.Get);
                var response = client.Execute(request);
                var content = response.Content;
                if (content == null)
                    return null;
                return JsonConvert.DeserializeObject<List<T>>(content);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}