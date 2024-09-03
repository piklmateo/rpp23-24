using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Entities
{
    public class EventProjection
    {
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public string Venue { get; set; }
        public string Organizer { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
    }

}
