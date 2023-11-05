using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static async Task ExampleRequest()
        {
            try
            {
                string reqUrl = "https://dummyjson.com/products/1";
                Console.WriteLine(reqUrl);
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(reqUrl);

                Console.WriteLine(response.EnsureSuccessStatusCode());
                Console.WriteLine(response.IsSuccessStatusCode.ToString());
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.Write(responseBody);
                Console.ReadLine();
                return;
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        static void Main(string[] args)
        {
            ExampleRequest().Wait();
        }
    }
}
