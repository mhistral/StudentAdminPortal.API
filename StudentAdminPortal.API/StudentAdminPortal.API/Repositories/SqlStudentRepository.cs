﻿using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context;

        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }


        public async Task<Student> GetStudentAsync(Guid studentId)
        {
            return await context.Student
                .Include(nameof(Gender)).Include(nameof(Address))
                .FirstOrDefaultAsync(x => x.Id == studentId);
        }

        public async Task<List<Gender>> GetGenderAsync()
        {
            return await context.Gender.ToListAsync();
        }

        public async Task<bool> Exists(Guid studentId)
        {
            // if the table has the row with the studentId
            return await context.Student.AnyAsync(x => x.Id == studentId);
        }

        // Task<RETURNTYPE>
        public async Task<Student> UpdateStudent(Guid studentId, Student request)
        {
            var existingStudent = await GetStudentAsync(studentId);

            if(existingStudent != null)
            {
                existingStudent.FirstName = request.FirstName;
                existingStudent.LastName = request.LastName;
                existingStudent.DateOfBirth = request.DateOfBirth;
                existingStudent.Email = request.Email;
                existingStudent.Mobile = request.Mobile;
                existingStudent.GenderId = request.GenderId;
                existingStudent.Address.PhysicalAddress = request.Address.PhysicalAddress;
                existingStudent.GenderId = request.GenderId;

                await context.SaveChangesAsync();

                return existingStudent;
            }
            return null;
        }
    }
}
