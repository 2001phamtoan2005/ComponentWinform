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
    public class Filter
    {
        public int count { get; set; } = 23;
        public int pageNums { get; set; } = 1;
    }
    public class BackEnd
    {
        RestClient client = new RestClient("http://data.gonsa.com.vn/api/product/test");

        /// <summary>
        /// Hàm xử lý lấy danh sách không có điều kiện kèm theo
        /// </summary>
        public List<T> GetSanPham<T>(Filter filter)
        {
            //string maChiTiet = "DOTD230505095501307";
            try
            {
                var request = new RestRequest($"http://data.gonsa.com.vn/api/customer/getCustomerForMiddleWare?pageNums={filter.pageNums}&count={filter.count}&type=allCustomer", Method.Get);
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

        public int GetSoLuongSanPham()
        {
            //string maChiTiet = "DOTD230505095501307";
            try
            {
                var request = new RestRequest($"http://data.gonsa.com.vn/api/customer/getCountCustomerForMiddleWare?type=allCustomer", Method.Get);
                var response = client.Execute(request);
                var content = response.Content;
                if (content == null)
                    return 0;
                return JsonConvert.DeserializeObject<int>(content);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}