using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotEdu.Domain.Entities
{
    public class Student
    {
        public Student()
        {
            StudentGroups = new HashSet<StudentGroup>();
            Attendances = new HashSet<Attendance>();
        }

        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<StudentGroup> StudentGroups { get;set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}
