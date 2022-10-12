using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using HelperLibrary;
using Oct12Exercises.Models;

namespace Oct12Exercises.Controllers
{
    public class BooksController : ApiController
    {
        Bookmethods ms = null;   
        public BooksController(){
            ms=new Bookmethods();
        }
        public static List<Bookmodel> s=new List<Bookmodel>();
        // GET: api/Books
        [Route("GetAllBook")]
        public IEnumerable<Bookmodel> Get()
        {
            List<Book> c = ms.getlist();
            foreach(var item in c)
            {
                s.Add(new Bookmodel
                {
                    BookId = (int)item.Book_No,
                    Bookname = item.Book_Name,
                    Author = item.Author,
                    Cost = (int)item.Cost,
                    category = item.Category

                });
            }
            return s;
        }

        // GET: api/Books/5
        [Route("findBook/{id}")]
        public Bookmodel Get(int id)
        {
            Book b = ms.findbook(id);
            Bookmodel m = new Bookmodel();
            m.BookId =(int) b.Book_No;
            m.Bookname = b.Book_Name;
            m.Author = b.Author;
            m.Cost = (int)b.Cost;
            m.category = b.Category;
            return m;
        }

        // POST: api/Books
        [Route("AddBook")]
        public HttpResponseMessage Post([FromBody]Bookmodel value)
        {
            Book b = new Book();
            b.Book_No = value.BookId;
            b.Book_Name = value.Bookname;
            b.Author = value.Author;
            b.Cost = value.Cost;
            b.Category = value.category;
            bool s=ms.AddBook(b);
            if (s)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }

        // PUT: api/Books/5
        [Route("UpdateBook/{id}")]
        public HttpResponseMessage Put(int id, [FromBody]Bookmodel value)
        {
            Book b = new Book();
            b.Book_No = value.BookId;
            b.Book_Name = value.Bookname;
            b.Author = value.Author;
            b.Cost = value.Cost;
            b.Category = value.category;
           bool s=ms.updatebook(id, b);
            if (s)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }

        // DELETE: api/Books/5
        [Route("deletebook/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            bool s=ms.deletebook(id);
            if (s)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }
    }
}
