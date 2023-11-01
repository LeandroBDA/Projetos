using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SuperHeroCntroller : ControllerBase
    {
        private static List<SuperHEro> heroes = new List<SuperHEro>
        {
            new SuperHEro
            {
                Id = 1,
                Name = "Spider Man",
                FirstName = "Peter",
                LastName = "Parker",
                Place = "New York City"
            },
            
            new SuperHEro
            {
                Id = 2,
                Name = "Iron Man",
                FirstName = "Tony",
                LastName = "Stark",
                Place = "New York City"
            },
            
            new SuperHEro
            {
                Id = 3,
                Name = "Captain America",
                FirstName = "Steve",
                LastName = "Roggers",
                Place = "Brooklin"
            },
            
        }; 
        
        [HttpGet]
        public async Task<ActionResult<List<SuperHEro>>> Get()
        {
            return Ok(heroes);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<SuperHEro>>> Get(int id)
        {
            var hero = heroes.Find(h => h.Id == id);
            if (hero == null)
               return BadRequest("Hero does not exist, please try again.");
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHEro>>> AddHero(SuperHEro hero)
        {
            heroes.Add(hero);
            return Ok(heroes);
        }
        
        [HttpPut]
        public async Task<ActionResult<List<SuperHEro>>> UpdateHero(SuperHEro request)
        {
            var hero = heroes.Find((h => h.Id == request.Id));
            if (hero == null)
                return BadRequest("Hero does not exist, please try again.");

            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;
            
            return Ok(heroes);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHEro>>> Delete(int id)
        {
            var hero = heroes.Find(h => h.Id == id);
            if (hero == null)
                return BadRequest("Hero does not exist, please try again.");

            heroes.Remove(hero);
            return Ok(heroes);
        }
        
    }
}