using StudentRegistrationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentRegistrationDemo.Controllers
{
    public class StudentRegController : ApiController
    {
        static List<Student> stud = new List<Student>()
        { 
            new Student{Id = 100,Name="Geraald Nimooy",age=14},
             new Student{Id = 101,Name="Jeramy Weeler",age=16},
              new Student{Id = 102,Name="Gerry Newlyr",age=15},
             new Student{Id = 10,Name="Jimy Wxlr",age=16},
        };
        // GET: api/StudentReg
        public List<Student> Get()
        {
            return stud;
        }

        // GET: api/StudentReg/5
        public Student Get(int id)
        {
            return stud.Where(x=> x.Id == id).FirstOrDefault();
        }

        // POST: api/StudentReg
        public string Post([FromBody]Student val)
        {
            stud.Add(val);
            return "student successfully registered";
        }

        // PUT: api/StudentReg/5
        public string Put(int id, [FromBody]Student value)
        {
            for (int i=0; i < stud.Count; i++)
            {
                Student std = stud.ElementAt(i);
                if (std.Id.Equals(id))
                {
                    stud[i] = value;
                    return "Student details Updated";
                }
            }
            return "Updation Failed";
        }

        // DELETE: api/StudentReg/5
        public string Delete(int id)
        {
            for (int i = 0; i < stud.Count; i++)
            {
                Student std = stud.ElementAt(i);
                if (std.Id.Equals(id))
                {
                    stud.RemoveAt(i);
                    return "student successfully Removed";
                }
            }
            return "student removal un-successful";
        }
    }
}
