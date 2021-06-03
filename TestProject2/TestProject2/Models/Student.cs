using System.Collections.Generic;

namespace TestProject2.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public List<string> DateOfBirthList { get; set; }
        public string CurrentAddress { get; set; }
        public string Gender { get; set; }
        public string Hobby { get; set; }
    }
}
