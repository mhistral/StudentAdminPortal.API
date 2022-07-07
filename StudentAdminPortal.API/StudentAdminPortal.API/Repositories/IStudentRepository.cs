

using StudentAdminPortal.API.DataModels;
using System.Collections.Generic;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository // being called in SqlStudentRepository
    {
        List<Student> GetStudents();
    }
}
