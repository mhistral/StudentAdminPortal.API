

using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    // this needs to be implemented first before the SqlStudentRepository
    public interface IStudentRepository // being called in SqlStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentAsync(Guid studentId);

        Task<List<Gender>> GetGenderAsync();

        Task<bool> Exists(Guid studentId);

        Task<Student>UpdateStudent(Guid studentId, Student request);

    }
}
