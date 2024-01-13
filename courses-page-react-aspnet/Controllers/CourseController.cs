using courses_page_react_aspnet.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace courses_page_react_aspnet.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private static readonly IEnumerable<CourseModel> Courses = new[]
        {
           new CourseModel {
              Id = 1,
              Category = "programming",
              Name = "Programming for beginners",
              Img = "/images/programing-for-beginners.jpg",
              Description = "In this course, you will learn the fundamental principles of programming, from basic syntax and variables to control flow and data structures. You will also gain hands-on experience by writing your own code and solving real-world problems.",
              Address = "Lotysska 10",
              City = "Brno",
              Capacity = 5
            },
           new CourseModel {
              Id = 2,
              Category = "cooking",
              Name = "Cooking lessons for beginners",
              Img = "/images/cooking-lessons-for-beginners.jpg",
              Description = "Embark on a culinary adventure with our 'Cooking for Beginners' course and discover the joy of creating delectable dishes from scratch. This comprehensive guide will equip you with the fundamental skills and techniques to transform your kitchen into a haven of culinary creativity.",
              Address = "Lotysska 8",
              City = "Prague",
              Capacity = 8
            },
            new CourseModel {
              Id = 3,
              Category = "music",
              Name = "Piano lessons for beginners",
              Img = "/images/piano-lessons-for-beginners.jpg",
              Description = "Whether you've always dreamed of tickling the ivories or simply want to add a new skill to your repertoire, our 'Piano Lessons for Beginners' course is the perfect starting point. This comprehensive guide will introduce you to the fundamentals of piano playing, from identifying notes on the keyboard to mastering basic chords and melodies.",
              Address = "Spanelska 13",
              City = "Prague",
              Capacity = 3
            },
            new CourseModel {
              Id = 4,
              Category = "art",
              Name = "Painting lessons for beginners",
              Img = "/images/painting-lessons-for-beginners.jpg",
              Description = "Welcome to the world of art and creativity! This comprehensive course will guide you through the exciting process of learning to paint. Whether you're an aspiring artist or simply want to explore your artistic side, this course will provide the perfect foundation to unleash your creative potential.",
              Address = "Evropska 1/12",
              City = "Prague",
              Capacity = 12
            },
            new CourseModel {
              Id = 5,
              Category = "cooking",
              Name = "Czech cuisine lessons",
              Img = "/images/czech-cuisine-lessons.jpg",
              Description = "Czech cuisine is a hearty and flavorful blend of Central European influences, with its roots in the rich agricultural traditions of the region. From savory main courses to sweet pastries, Czech cuisine offers a delightful culinary experience that will tantalize your taste buds.",
              Address = "Stodolni 22",
              City = "Brno",
              Capacity = 20
            }
        };

        [HttpGet()]
        public ActionResult Get()
        {
            try
            {
                return Ok(Courses.ToArray());

        }catch(Exception ex)
            {
                return BadRequest(ex.Message);
    }
}

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                var course = Courses.FirstOrDefault(c => c.Id == id);
            return Ok(course);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
