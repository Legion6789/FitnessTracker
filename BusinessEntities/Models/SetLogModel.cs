using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models
{
    public class SetLogModel
    {
        public Guid setLogId { get; set; }
        public Guid workoutLogId { get; set; }
        public ExerciseModel exercise { get; set; }
        public int setNumber { get; set; }
        public int repsAchieved { get; set; }
        public int weight { get; set; }
        public int RPE { get; set; }
    }
}
