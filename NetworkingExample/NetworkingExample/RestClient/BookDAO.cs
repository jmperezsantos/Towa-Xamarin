using System;
using System.IO;
using System.Net;
using NetworkingExample.Model;
using Newtonsoft.Json;

namespace NetworkingExample.RestClient
{
    public class BookDAO
    {
        public BookDAO()
        {
        }

        public static async void getAllBooksAsync(
            Action<BookModel[]> success,
            Action<string> error
        )
        {
            string url = "https://baas.kinvey.com/appdata/kid_BJdgb3Scf/books";

            HttpWebRequest request = HttpWebRequest.CreateHttp(url);

            request.Headers["Authorization"] = "Basic a2lkX0JKZGdiM1NjZjpmNTdlZmE5NmUwODY0NzljYTE3MTI0MmY0YWJjODU2OA==";
            request.Headers["X-Kinvey-API-Version"] = "3";
            request.Method = "GET";

            using (WebResponse response = await request.GetResponseAsync())
            {
                
                using (Stream stream = response.GetResponseStream())
                {

                    StreamReader reader = new StreamReader(stream);

                    string json = reader.ReadToEnd();

                    BookModel[] books = JsonConvert
                        .DeserializeObject<BookModel[]>(json);

                    //success(books);
                    success?.Invoke(books);

                }

            }

        }
    }
}
