using School.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DAL.Interface
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
    }
}
