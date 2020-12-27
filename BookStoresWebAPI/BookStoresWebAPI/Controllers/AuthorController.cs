using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookStoresWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Author> Get()
        {
            using (var _context = new BookStoresDBContext())  // Instans
            {
                //get all authors
                //return context.Author.ToList();

                // add an author in my database
                //Author author = new Author(); // add an author in my database
                //author.FirstName = "John"; // add an author in my database
                //author.LastName = "Smith"; // add an author in my database

                //context.Author.Add(author); // add an author in my database

                Author author = _context.Author.Where(auth => auth.FirstName == "John").FirstOrDefault();
                author.Phone = "777-777-7777";

                _context.SaveChanges(); // add an author in my database



                // get author by id
                return _context.Author.Where(auth => auth.FirstName == "John").ToList();
            }
        }
    }
}
