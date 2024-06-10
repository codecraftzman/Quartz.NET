using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz.Domain
{
    public class Dispute
    {
        public int DisputeId { get; set; }
        public int SessionId { get; set; }

        [ForeignKey("SessionId")]
        public Session Session { get; set; } = default!;
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; } = default!;
        public int RaisedById { get; set; }
        
        [ForeignKey("RaisedById")]
        public Employee RaisedBy { get; set; } = default!;
        public DisputeReason DisputeReason { get; set; } = default!;
        public Status Status { get; set; }
        public Source Source { get; set; }
        public ICollection<Activity> Ativities { get; set; } = default!;

    }
}
