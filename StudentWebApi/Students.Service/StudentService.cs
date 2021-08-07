using Students.Model;
using StudentsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Service
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;
        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public List<Student> GetStudents()
        {
            return _studentRepository.GetStudents();
        }

        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
        }

        public void DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
        }

        public void EditStudent(Student student)
        {
            _studentRepository.EditStudent(student);
        }
    }
}
