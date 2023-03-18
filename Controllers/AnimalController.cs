using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZooManagement.Repositories;
using ZooManagement.Request;
using ZooManagement.Response;
//add repos and request models from ZooManagement

namespace ZooManagement.Controllers
{
    [ApiController]
    [Route("/animals")]
    public class AnimalsController : ControllerBase
    {
        //remember to add a transient to use the interface below
        private readonly IAnimalsRepo _Animals;

        public AnimalsController(IAnimalsRepo animals)
        {
            _Animals = animals;
        }

        [HttpGet("{id}")]
        public ActionResult<AnimalResponse> GetById([FromRoute] int id)
        {
            var animal = _Animals.GetById(id);
            //Create this animalresponse
            return new AnimalResponse(animal);
        }

//Convert the string q here into a AnimalSearchRequest class that can take many parameters inc. Species parameters
// search through all of those parameters in the repo 
//Do a single api call to get all of the species classifications for use in the dbcontext (is this needed?)
        [HttpGet("")]
        public IActionResult Search(AnimalSearchRequest animalSearchRequest)
        {

            var results = _Animals.GetBySearch(animalSearchRequest); 

            return Ok(results);
        }

        // [HttpGet("")]
        // public ActionResult<UserListResponse> Search([FromQuery] AnimalSearchRequest searchRequest)
        // {
        //     var users = _users.Search(searchRequest);
        //     var userCount = _users.Count(searchRequest);
        //     return UserListResponse.Create(searchRequest, users, userCount);
        // }
    }
};