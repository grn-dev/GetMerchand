using GetMerchant.Entity;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GetMerchant
{
    public class Merchant : IMerchant
    {
        private const string URL_READ_REQUEST = "webService/readRequestCartableWithFilter";
        private const string URL_WRITE_REQUEST = "webService/writeExternalRequest";

        public HttpClient _client;
        public Merchant(HttpClient httpClient, string baseUrl)
        {
            _client = httpClient;
            BaseUrl = baseUrl;
             
        }

        public string BaseUrl
        {
            get => _baseUrl;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(BaseUrl));
                _baseUrl = value;
            }
        }
        private string _baseUrl;
 
        
         

        public async Task<ReadRequestCartableResponse> ReadRequestCartable(ShaparakReadRequest model)
        {
            if (model == null)
                throw new NullReferenceException("The model cannot be null.");

            string url = $"{_baseUrl}/{URL_READ_REQUEST}";
            //ReadRequestCartableResponse result;

            //result = await _client
            //    .PostAsync<ShaparakReadRequest, ReadRequestCartableResponse>
            //        (model, url, getHeaders());

            var newjsonmodel = new StringContent(
                    JsonConvert.SerializeObject(model),
                    Encoding.UTF8,
                    "application/json");

            try
            {
                var result2 = await _client.PostAsync(
                url,
                newjsonmodel
            );
            }
            catch (Exception ex)
            {

                throw;
            }

            //if (!result2.IsSuccessStatusCode)
                throw new HttpRequestException();

            //TODO
            return new ReadRequestCartableResponse();
        }


        

    }
}
