using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibHighscore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HighscoreController : ControllerBase
    {
        private static List<Highscore> HScores = new List<Highscore>();
        // GET: api/Highscore
        [HttpGet]
        public List<Highscore> Get()
        {
            return HScores;
        }

        // GET: api/Highscore/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Highscore
        [HttpPost ("High")]
        public void Post([FromBody] Highscore Data)
        {
            HScores.Add(Data);
        }

        // PUT: api/Highscore/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
