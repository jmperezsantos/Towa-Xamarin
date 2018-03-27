using System;
using Newtonsoft.Json;
namespace NetworkingExample.Model
{
    public class BookModel
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("bookTitle")]
        public string Title { get; set; }

        [JsonProperty("bookAuthor")]
        public string Author { get; set; }

        [JsonProperty("bookImage")]
        public string Image { get; set; }

        public BookModel()
        {
        }

        public BookModel(string id,
                         string title,
                         string author,
                         string image)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.Image = image;
        }

		public override string ToString()
		{
            return $"[BookModel Id:{Id} Title:{Title} Author:{Author} Image{Image}]";
		}
	}
}
