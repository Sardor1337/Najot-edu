using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotEdu.Domain.Entities
{
    public class Lesson
    {
        public Lesson()
        {
            Attendances = new HashSet<Attendance>();
        }

        public int Id { get; set; }
        public int GroupId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTIme { get; set; }

        public Group Group { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
        
    }
}
