using MaskeTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip.Business
{
    public class CourseManager
    {
        Course[] courses = new Course[3]; 
        public CourseManager()
        {
            Course course1 = new Course
            {
                Id = 1, Name = "C#", Description = ".Net 8 vs...", Price = 0
            };
            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java";
            course2.Description = "Java 17 ....";
            course2.Price = 10;

            Course course3 = new Course
            {
                Id=3, Name ="Python",Description="3,12 .....",Price=20
            };

            courses[0]=course1;
            courses[1]=course2;
            courses[2]=course3;
        }

        public Course[] GetAll()
        {
            return courses;
        }


    }
}
