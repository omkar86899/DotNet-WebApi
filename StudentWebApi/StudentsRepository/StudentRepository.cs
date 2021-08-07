using Students.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsRepository
{
    public class StudentRepository : IStudentRepository
    {
        private StudentDbContext _db;

        public StudentRepository()
        {
            _db = new StudentDbContext();
        }

        public List<Student> GetStudents()
        {
            return _db.Students.ToList<Student>();
        }

        public void AddStudent(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            Student student = _db.Students.Where(s => s.Id == id).First();
            _db.Students.Remove(student);
            _db.SaveChanges();
        }

        public void EditStudent(Student student)
        {
            Student oldStudent = _db.Students.Where(s => s.Id == student.Id).First();

            oldStudent.Name = student.Name;
            oldStudent.RollNo = student.RollNo;
            oldStudent.Age = student.Age;
            oldStudent.Date = student.Date;
            oldStudent.Email = student.Email;
            oldStudent.IsMale = student.IsMale;

            _db.SaveChanges();
        }
    }
}
