using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Investigation.API.Data;
using Investigation.Shared.Entities;


namespace Investigation.API.Controllers
{
    
        [ApiController]
        [Route("/api/projects")]

        public class ProjectsController : ControllerBase
        {
            private readonly DataContext _context;


            public ProjectsController(DataContext context)
            {
                _context = context;
            }



            //Get con lista
            //Select * From owners

            [HttpGet]
            public async Task<ActionResult> Get()
            {

                return Ok(await _context.Projects.ToListAsync());


            }

            // Get por parámetro
            [HttpGet("{id:int}")]
            public async Task<ActionResult> Get(int id)
            {

                //200 Ok

                var project = await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);

                if (project == null)
                {


                    return NotFound();
                }

                return Ok(project);


            }



        [HttpPost]
        public async Task<ActionResult> Post(Project project)
        {

            _context.Add(project);
            await _context.SaveChangesAsync();
            return Ok(project);

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
