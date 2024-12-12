using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string ?Name { get; set; }
        public string? Email { get; set; }
        public DateTime? MembershipDate { get; set; }
        public ICollection<Loan> Members { get; set; }
    }
}
