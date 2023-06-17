using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models
{
    public class WorkoutLogModel
    {
        public Guid workoutLogId { get; set; }
        public Guid workoutId { get; set; }
        public DateTime workoutDate { get; set; }
        public List<SetLogModel> setLog { get; set; }
    }
}
