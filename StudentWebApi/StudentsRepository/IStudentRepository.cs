using Students.Model;
using System.Collections.Generic;

namespace StudentsRepository
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();

        void AddStudent(Student student);

        void DeleteStudent(int id);

        void EditStudent(Student student);
    }
}