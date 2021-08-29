using AnyName.Data;
using AnyName.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnyName.Controllers
{
    //www.localhost.com/api/Rozh
    [Route("api/[controller]")]
    [ApiController]
    public class RozhController : ControllerBase
    {
        private readonly MyContext  _db;
        public RozhController(MyContext myContext)
        {
            _db = myContext;
        }

        //GET: ../Api/Rozh
        [HttpGet]
        public List<Student> PrintName()
        {
            var students = _db.Students.ToList();
            return students;
        }
        [HttpGet("{id}")]
        public string PrintName3(int id)
        {
            
            return "Hello Third " + id;
        }
        //GET: ../Api/Rozh/Second
        [HttpGet("Second")]
        public string PrintName2()
        {
            return "Hello Jutayr";
        }

        //GET: ../Api/Rozh/Second
        [HttpGet("Second/{name}")]
        public string PrintName4(string name)
        {
            return "Hello " + name;
        }

        //POST: ./api/Rozh
        [HttpPost]
        public Student GetStudent(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            return student;
        }

        //GET: ./api/Rozh/anotherOne
        [HttpGet("anotherOne")]
        public Student GetStudent2(Student student)
        {
            return student;
        }

        //GET: ./api/Rozh/anotherOne/3232
        [HttpGet("anotherOne/{id}")]
        public Student GetStudent3(int id, Student student)
        {
            student.Id = id;
            return student;
        }
    }

}
