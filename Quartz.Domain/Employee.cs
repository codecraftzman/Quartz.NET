using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quartz.Domain
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public int ParentId { get; set; }

        [ForeignKey("ParentId")]
        public Employee Parent { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public EmployeeType EmployeeType { get; set; }
        public ICollection<Employee> Subordinates { get; set; } = default!;
                
    }
}
