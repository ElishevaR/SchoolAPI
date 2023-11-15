using School.DAL.Interface;
using School.Model;
using School.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DAL
{
    public class StudentRepository : IStudentRepository
    {
        readonly SchoolContext _SchoolContext;
        public StudentRepository(SchoolContext SchoolContext)
        {
            _SchoolContext = SchoolContext;
        }

        public List<Student> GetAll()
        {
            return _SchoolContext.students.ToList();
        }
    }
}
