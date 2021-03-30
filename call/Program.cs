using GetMerchant;
using GetMerchant.Entity;
using System;
using System.Net.Http;

namespace call
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var client = new HttpClient();
            string baseUrl = "";

            //client.DefaultRequestHeaders.Add("X-Version", "1");
            //client.DefaultRequestHeaders.Add("X-Version", "1"); 

            GenerateUserpass generate = new GenerateUserpass();

            var resBase64= generate.getAuthorizationValue("usertest", "passTEST");
            client.DefaultRequestHeaders.Add("Authorization", resBase64);
            //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "keep-alive");


            //client.PostAsync();

            //var result = await client.GetAsync("http://webcode.me");

            Merchant merchant = new Merchant(client, "http://newtejaratasan.niopdc.ir/");

            ShaparakReadRequest shaparakReadRequest = new ShaparakReadRequest() 
            {

            };
            var res=merchant.ReadRequestCartable(shaparakReadRequest);



            Console.WriteLine("");





        }

        
    }
}
