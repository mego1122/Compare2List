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
    public class UserController : ControllerBase
    {

        public static List<User> GetUsers1()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "Kamal",
                    Address = "Colombo",
                    Height = 10.5
                },
                new User
                {
                    Id = 2,
                    Name = "Nimal",
                    Address = "Kandy",
                    Height = 14
                },
                new User
                {
                    Id = 3,
                    Name = "Vimal",
                    Address = "Kurunegala",
                    Height = 12.5
                },
                new User
                {
                    Id = 4,
                    Name = "Namal",
                    Address = "Gampaha",
                    Height = 11
                },

            };
        }

        public static List<User> GetUsers2()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "Kamal",
                    Address = "Colombo",
                    Height = 10.5
                },
                new User
                {
                    Id = 2,
                    Name = "Nimal",
                    Address = "Kandy",
                    Height = 15
                },
                new User
                {
                    Id = 3,
                    Name = "Vimal",
                    Address = "Kaluthara",
                    Height = 12.5
                },
                new User
                {
                    Id = 4,
                    Name = "Himal",
                    Address = "Gampaha",
                    Height = 11
                },

            };
        }



        public void cmpr()
        {
            var users1 = GetUsers1();
            var users2 = GetUsers2();

            Console.WriteLine("Matching Users for [Name, Address]: ");

            var uSearch1 = from first1 in users1
                           join second1 in users2
                                       on new { first1.Name, first1.Address } equals new { second1.Name, second1.Address }
                           select first1;

            foreach (var user in uSearch1)
            {
                Console.WriteLine($"Id: {user.Id} Name: {user.Name} Address: {user.Address} Height: {user.Height}");
            }

            


        }
    }
}
