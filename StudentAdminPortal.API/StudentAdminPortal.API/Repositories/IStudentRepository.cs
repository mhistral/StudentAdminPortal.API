

using StudentAdminPortal.API.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository // being called in SqlStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
