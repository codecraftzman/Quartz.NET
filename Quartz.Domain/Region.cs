using System.ComponentModel.DataAnnotations.Schema;

namespace Quartz.Domain
{
    public class Region
    {
        public int RegionId { get; set; }
        public string Name { get; set; } = default!;
        public string TimeZoneId { get; set; } = default!;
        public double OffsetHours { get; set; }

        [NotMapped]
        public TimeZoneInfo TimeZone
        {
            get
            {
                return TimeZoneInfo.FindSystemTimeZoneById(TimeZoneId);
            }
        }

    }
}