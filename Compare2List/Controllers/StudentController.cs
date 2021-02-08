using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compare2List.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Compare2List.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
       static List<Student> list1 = new List<Student>() { 
        new Student(){Id=1,Name="Mohamed",Email="m@gmail.com"},
        new Student(){Id=2,Name="Ahmed",Email="A@gmail.com"},
        new Student(){Id=3,Name="Ali",Email="ALI@gmail.com"},
        new Student(){Id=4,Name="Hema",Email="HEMA@gmail.com"}

        };

        static List<Student> list2 = new List<Student>() {
        new Student(){Id=1,Name="Mohamed",Email="m@gmail.com"},
        new Student(){Id=2,Name="Ahmed",Email="A@gmail.com"},
        new Student(){Id=3,Name="Ali",Email="ALI@gmail.com"},
         new Student(){Id=4,Name="Hema",Email="HEMA@gmail.com"}

        };



        [HttpGet]
        public bool CompareListway2()
        {

            return list1.Count() == list2.Count() && !list1.Except(list2).Any();

        }



        //[HttpGet]
        //public bool CompareList2()
        //{

        //    var a = list1.GetType();
        //    var b = list2.GetType();

        //    if (a == b)
        //    {
        //        if (list1.Count() == list2.Count())
        //        {
        //            var filteredSequence = list1.Where(x => list2.Contains(x));


        //            if (filteredSequence.Count() == list1.Count())
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
                   

        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }


        //}



    }
}
