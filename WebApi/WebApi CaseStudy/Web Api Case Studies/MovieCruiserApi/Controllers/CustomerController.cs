using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCruiserApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCruiserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<MovieList> Get()
        {
            DateTime dt = DateTime.Now;
            return MovieListOperations.GetConnection().Where(p => p.Active == true && p.DateOfLaunch <= dt);

        }

        [HttpGet("{userid}", Name = "Get Customer")]
        public object Get(int userid)
        {
            int movieCount = 0;
            List<MovieList> list = new List<MovieList>(MovieListOperations.FavoriteList(userid, ref movieCount));

            return new { list, movieCount };
        }

        [HttpPost]
        public IActionResult Post([FromBody] List<Favorites> fav)
        {
            MovieListOperations.InsertIntoFavorites(fav);
            return Ok();
        }

        [HttpDelete("{favId}")]
        public string Delete(int favId)
        {
            return MovieListOperations.Delete(favId);
        }
    }
}
