using EMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EMS.Repository
{
    class StudentRepository
    {
        private EMSContext _db;
        public StudentRepository()
        {
            _db = new EMSContext();
        }
        public void AddStudent(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
        }

        public void RemoveStudent(int studentID)
        {
            Student student = _db.Students.FirstOrDefault(a => a.StudentID == studentID);
            if (student != null)
            {
                _db.Students.Remove(student);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("StudentID doesnt exist");
            }
        }

        public Student UpdateStudent(Student student)
        {

            return null;
        }

        public Student GetStudent(int studentID)
        {

            return _db.Students.FirstOrDefault(a => a.StudentID == studentID);
        }

        public List<Student> GetMails()
        {
            return _db.Students.ToList();
        }

    }
}
