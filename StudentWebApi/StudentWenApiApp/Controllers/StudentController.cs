using Newtonsoft.Json;
using Students.Model;
using Students.Service;
using StudentWebApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentWebApiApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/v1/students")]
    public class StudentController: ApiController
    {
        private IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [Route("")]
        public IHttpActionResult GetStudents()
        {
            List<Student> students = _studentService.GetStudents();
            List<Object> lowerStudents = new List<Object>();
            
            foreach(Student student in students)
            {
                lowerStudents.Add(new { id = student.Id, rollNo = student.RollNo, name = student.Name, age = student.Age, email = student.Email, date = student.Date, isMale = student.IsMale });
            }
            return Json(lowerStudents);
        }

        [Route("")]
        public IHttpActionResult PostStudent(StudentModel student)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest("Data is Not Valid");
            }
            Student newStudent = new Student
            {
                Name = student.name,
                RollNo = student.rollNo,
                Age = student.age,
                Email = student.email,
                Date = student.date,
                IsMale = student.isMale
            };

            _studentService.AddStudent(newStudent);

            return Json(newStudent.Id);
        }

        [Route("{studentId}")]
        public IHttpActionResult DeleteStudent(int studentId)
        {
            _studentService.DeleteStudent(studentId);
            return Json(studentId);
        }

        [Route("{studentId}")]
        public IHttpActionResult PutStudent(int studentId, StudentModel student)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest("Data is Not Valid");
            }
            Student newStudent = new Student
            {
                Id = studentId,
                Name = student.name,
                RollNo = student.rollNo,
                Age = student.age,
                Email = student.email,
                Date = student.date,
                IsMale = student.isMale
            };
            _studentService.EditStudent(newStudent);
            return Ok(studentId);
        }
    }
}