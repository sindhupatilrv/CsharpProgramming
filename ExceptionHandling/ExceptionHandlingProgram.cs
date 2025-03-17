using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json.Linq;

namespace ExceptionHandling
{
    public class ExceptionHandlingProgram
    {
        public const string BaseUrl = "https://bookstore.toolsqa.com";
        public const string username = "test";
        public const string password = "test";
        public const string postEndpoint = "/Account/v1/Authorized";
        public const string postUser = "BookStore/v1/Books";
        public const string getBookStoreapi = "BookStore/v1/Books";
        public const string jsonString = "{\"userId\":\"76\",\"collectionOfIsbns\":[{\"isbn\":\"9781593277574\"}]}";


        //string AccountRequestData = "{\"userName\":\"username\", \"password\":\"password\"}";
        public static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var byteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Convert.ToBase64String(byteArray));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync(BaseUrl);
            if (response.IsSuccessStatusCode)
            {
                Debug.Assert(Equals(response.StatusCode, 200));
                Console.WriteLine($"Success! Response Code: {(int)response.StatusCode}");
            }
            else
            {
                Console.WriteLine($"Failed! Response Code: {(int)response.StatusCode}");
            }
            await getBookStore(client);
            await postcallcheck(client);
        }
        public static async Task getBookStore(HttpClient client)
        {
            //Get call -https://bookstore.toolsqa.com/BookStore/v1/Books'
            try
            {
                HttpResponseMessage getBookStoreResponse = await client.GetAsync(getBookStoreapi);
                string responseBody = await getBookStoreResponse.Content.ReadAsStringAsync();
                var parsedJson = JObject.Parse(responseBody);
                if (getBookStoreResponse.IsSuccessStatusCode)
                {
                    Debug.Assert(Equals(getBookStoreResponse.StatusCode, 200));
                    Console.WriteLine("GET call: BookStore/v1/Books response data is:" + parsedJson);
                }
                else
                {
                    Debug.Fail(
                        $"Failed!- GET call: BookStore/v1/Books Response Code: {(int)getBookStoreResponse.StatusCode}");
                    Console.WriteLine($"Failed!- GET call: BookStore/v1/Books Response Code: {(int)getBookStoreResponse.StatusCode}");
                }


            }
            catch (SystemException exception)
            {
                Console.WriteLine($"Exception caught: {exception.Message}");
            }
        }

        public static async Task postcallcheck(HttpClient client)
        {
            try
            {
               
                //string jsonData = @"{ ""userName"": ""Test"", ""password"": ""TestRestApi.@23444""}";

                HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                Console.WriteLine("HTTP Content: " + await content.ReadAsStringAsync());

                HttpResponseMessage postresponse = await client.PostAsync(postUser, content);

                if (postresponse.IsSuccessStatusCode)
                {
                    Debug.Assert(Equals(postresponse.StatusCode, 200));
                    Console.WriteLine($"Success! Response Code: {(int)postresponse.StatusCode}");
                    string responseBody = await postresponse.Content.ReadAsStringAsync();
                    Console.WriteLine($"Response Body: {responseBody}");
                }
                else
                {
                    //Console.WriteLine($"$Error: {response.StatusCode}");
                    Console.WriteLine($"POST CALL :Failed! Response Code: {(int)postresponse.StatusCode}");
                }

            }
            catch (SystemException exception)
            {
                Console.WriteLine($"Exception caught: {exception.Message}");
            }

        }

    }
}

