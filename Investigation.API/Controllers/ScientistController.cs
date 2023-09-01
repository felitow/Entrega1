using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Investigation.API.Data;
using Investigation.Shared.Entities;


namespace Investigation.API.Controllers
{
    
        [ApiController]
        [Route("/api/scientists")]

        public class SciencistsController : ControllerBase
        {
            private readonly DataContext _context;


            public SciencistsController(DataContext context)
            {
                _context = context;
            }



            //Get con lista
            //Select * From owners

            [HttpGet]
            public async Task<ActionResult> Get()
            {

                return Ok(await _context.Scientists.ToListAsync());


            }

            // Get por parámetro
            [HttpGet("{id:int}")]
            public async Task<ActionResult> Get(int id)
            {

                //200 Ok

                var scientist = await _context.Scientists.FirstOrDefaultAsync(x => x.Id == id);

                if (scientist == null)
                {


                    return NotFound();
                }

                return Ok(scientist);


            }



        [HttpPost]
        public async Task<ActionResult> Post(Scientist scientist)
        {

            _context.Add(scientist);
            await _context.SaveChangesAsync();
            return Ok(scientist);

        }

        //[HttpPost]
        //public async Task<ActionResult> Post(Country country)
        //{
        //    _context.Add(country);
        //    await _context.SaveChangesAsync();
        //    return Ok(country);
        //}
    }
    }

