using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZooManagement.Models;
using ZooManagement.Repositories;
using ZooManagement.Response;
//add repos and request models from ZooManagement

namespace ZooManagement.Controllers
{
    [ApiController]
    [Route("/species")]
    public class SpeciesController : ControllerBase
    {
        //remember to add a transient to use the interface below
        private readonly ISpeciesRepo _Species;

        public SpeciesController(ISpeciesRepo species)
        {
            _Species = species;
        }
        
        [HttpGet("{id}")]
        public ActionResult<SpeciesResponse> GetById([FromRoute] int id)
        {
            var species = _Species.GetById(id);
            //Create this animalresponse
            return new SpeciesResponse(species);
        }

        [HttpGet("all")]
        public ActionResult<DbSet<Species>> GetAllSpecies()
        { 
            var ourList = _Species.GetAllSpecies();
            return ourList;

            }
    }
}; 

/*
 public List<string> RetrieveBooksList()
    {
        using (var context = new BookishContext())
        {
            var catalogue = context.Catalogue;
            var book = context.Books;

            var query = book.GroupJoin(catalogue,
            //where to join
            book => book.Catalogue_id,
            catalogue => catalogue.Id,
            (book, bookGroup) => new
            {
                BookItem = book.Catalogue,
                BookCondition = book.Condition
            });

            var bookList = new List<string>();

            foreach (var ourBook in query)
            {
                bookList.Add($"{ourBook.BookItem.Title}, {ourBook.BookItem.Author}, {ourBook.BookItem.PublicationYear} and {ourBook.BookCondition}");
            }

            return bookList;

        }
    }
}

*/
