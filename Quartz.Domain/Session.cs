using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz.Domain
{
    public class Session
    {
        public int SessionId { get; set; }
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; } = default!;
        public int SheduleId { get; set; }

        [ForeignKey("SheduleId")]
        public ShiftSchedule Schecdule { get; set; } = default!;
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set;}
        public DateOnly ShiftDate { get; set; }
        public int RegularHours { get; set; }
        public ICollection<Dispute> Disputes { get; set; } = default!;
    }

}
