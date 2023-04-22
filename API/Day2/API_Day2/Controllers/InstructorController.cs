using API_Day2.Data.Context;
using Day2.DAL.Data.Models;
using Day2.DAL.Repo;
using Microsoft.AspNetCore.Mvc;

namespace API_Day2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : Controller
    {
       
        public IInstructorRepo InstructorRepo { get; }
 
        public InstructorController(IInstructorRepo IRepo)
        {
            InstructorRepo = IRepo;
          
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            List<Instructor> instructors = InstructorRepo.GetAll().ToList();
            if (instructors.Count > 0)
            {
                return Ok(instructors);
            }
            return BadRequest();
        }

        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(InstructorRepo.GetById(Id));
        }

        //Add
        [HttpPost]
        public ActionResult Add(Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                InstructorRepo.Insert(instructor);
                return NoContent();
            }
            return BadRequest();
        }

        //edit
        [HttpPut]
        public ActionResult Edit(int id, Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                if (id != instructor.ID)
                    return BadRequest();

                InstructorRepo.UpdateInstructor(id, instructor);
                return Ok(instructor);
            }

            return BadRequest();
        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
           
            if (id != null)
            {
                var inst = InstructorRepo.GetById(id);
                InstructorRepo.DeleteInstructor(id);
                return Ok(inst);
               
            }
            return NotFound();
        }


    }
}
