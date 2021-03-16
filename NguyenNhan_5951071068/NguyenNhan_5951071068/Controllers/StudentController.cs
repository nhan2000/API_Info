using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NguyenNhan_5951071068.Models;

namespace NguyenNhan_5951071068.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<Student> Get()
        {
            var StudentList = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                var Student = new Student
                {
                    idStudent = i.ToString(),
                    NameStudent = $"Name {i}",
                    Email = $"Name{i}",
                    AddressStudent = $"{i}" + $"{ i + 1}" + $"{ i + 2}" + $"{ i + 3}"
                    


                };
                StudentList.Add(Student);

            }
            return StudentList;
        }

        // GET: api/Student/5
        public Student Get(String id)
        {
            if (String.Compare(id, "5951071068", true) == 0)
            {
                return new Student
                {
                    NameStudent = "Nguyễn Nhân",
                    idStudent = id.ToString(),
                    Email = "nhan2000ts@gmail.com",
                    AddressStudent = "Bình Định"
                    
                };

            }
            return new Student
            {
                idStudent = id.ToString(),
                NameStudent = $"Name {id}",
                Email = $"Name{id}",
                AddressStudent = $"{id}" + $"{ id + 1}" + $"{ id + 2}" + $"{ id + 3}"

            }; ;
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
