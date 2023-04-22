using Microsoft.AspNetCore.Mvc;
using Day1.Models;
using System.Linq;
using System.Linq.Expressions;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        public CourseDBContext DB { get; }
        public CourseController(CourseDBContext DB)
        {
            this.DB = DB;
        }

        //GetAll
        [HttpGet]
        public ActionResult <List<Courses>> GetAll()
        {
            if (DB.Courses.ToList() != null)
            {
                return Ok(DB.Courses.ToList());
            }
            return NotFound();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Courses course = DB.Courses.Find(id);
            if (course != null)
            {
                DB.Courses.Remove(course);
                DB.SaveChanges();
                return Ok(course);
            }
            return NotFound();
        }

        //edit
        [HttpPut]
        public ActionResult Edit(Courses course)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    DB.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    DB.SaveChanges();
                    return Ok(course);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
            return NotFound();
        }


        //Add
        [HttpPost]
        public ActionResult Add(Courses course)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (course != null)
                    {
                        DB.Add(course);
                        DB.SaveChanges();
                        return Ok(course);
                    }
                 
                }catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return NotFound();
        }
        

        //GetByID
        [HttpGet ("{id:int}")]
        public ActionResult <Courses> GetByID(int id)
        {
        
           if(DB.Courses.Find(id) != null)
           {
                return Ok(DB.Courses.Find(id));
           }
            return NotFound(); 
            
        }

        //GetByName
        [HttpGet("{name:alpha}")]
        public ActionResult<Courses> GetByName( string name)
        {
            Courses course = DB.Courses.Where(c => c.Name == name).FirstOrDefault();
            if (course != null)
            {
                return Ok(course);
            }
            return NotFound();

        }
    }
}
