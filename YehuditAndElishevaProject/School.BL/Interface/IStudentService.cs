using School.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BL.Interface
{
    public interface IStudentService
    {
        List<Student> GetAll();
    }
}
