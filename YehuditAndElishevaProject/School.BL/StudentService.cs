using School.BL.Interface;
using School.DAL.Interface;
using School.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BL
{
    public class StudentService : IStudentService
    {
        readonly IStudentRepository _StudentRepository;
        public StudentService(IStudentRepository StudentRepository)
        {
            _StudentRepository = StudentRepository;
        }
        public List<Student> GetAll()
        {
            return _StudentRepository.GetAll();
        }
    }
}
