
using System;

namespace StudentAdminPortal.API.Domain_Models
{
    // we will have the properties here that we want the request object to have
    // property that we want the user to change
    public class UpdateStudentRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public Guid GenderId { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }

    }
}
