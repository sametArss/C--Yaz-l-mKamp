using MaskeTakip.Business;
using MaskeTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CourseManager manager = new CourseManager();
            Course [] course =manager.GetAll();

            for(int i = 0; i < course.Length; i++)
            {
                Console.WriteLine(course[i].Name+" / " + course[i].Price);
            }


            Console.ReadLine();
        }
    }
}
