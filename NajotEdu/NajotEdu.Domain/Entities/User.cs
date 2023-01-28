using NajotEdu.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotEdu.Domain.Entities
{
    public class User
    {
        public User()
        {
            Groups= new HashSet<Group>();
        }
        public int Id { get; set; }
        public string HashPassword { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public UserRole Role { get; set; }

        public ICollection<Group> Groups { get; set; }

    }
}
