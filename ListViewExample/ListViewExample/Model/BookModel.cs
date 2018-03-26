using System;
namespace ListViewExample.Model
{
    public class BookModel
    {

        public string Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Image { get; set; }

        public BookModel() : this("", "", "","")
        {

        }

        public BookModel(string id, string title, string author, string image)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.Image = image;
        }

        public override string ToString()
        {
            //return String.Format("[BookModel Id:{0} Title:{1} Author:{2}]", Id, Title, Author);

            return $"[BookModel Id:{Id} Title:{Title} Author:{Author} Image:{Image}]";
        }
    }
}
