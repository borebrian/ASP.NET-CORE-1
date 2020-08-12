using Fuela_clients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fuela_clients.Repository
{
    public class Booksrepository
    {
        public List<BooksModel> GetAllBooks()
        {
            return OurDataSource();
        }

        public BooksModel GetBookById( int id)
        {
            return OurDataSource().Where(x => x.ID == id).FirstOrDefault();
        }

        public List<BooksModel> SearchBooks(string title, string authorname)
        {
            return OurDataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorname)).ToList();
        }

        private List<BooksModel> OurDataSource()
        {
            return new List<BooksModel>()
            {
                new BooksModel()
                {
                    ID=1,
                    Title="C@",
                    Author="Ken walibora",
                    Description="This is all about swahili books"
                  

                },  new BooksModel()
                {
                    ID=2,
                    Title="Kidagaa",
                    Author="Stephen Gates",
                    Description="This describes more about Kidagaa Kimemwozea"


                }, new BooksModel() {
                    ID=3,
                    Title="JAVA",
                    Author="Bill Gates",
                    Description="This is all about Microsoft Office"


                }, new BooksModel() {
                    ID=4,
                    Title="PYTHON",
                    Author="Henry Gerton",
                    Description="This is all about python Office"


                }, new BooksModel() {
                    ID=5,
                    Title="PHP",
                    Author="Melinda Gates",
                    Description="The co founders of Microsoft"


                },
            };
        }
    }
}
