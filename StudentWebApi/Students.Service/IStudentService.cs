using Students.Model;
using System.Collections.Generic;

namespace Students.Service
{
    public interface IStudentService
    {
        List<Student> GetStudents();

        void AddStudent(Student student);

        void DeleteStudent(int id);

        void EditStudent(Student student);
    }
}