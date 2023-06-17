namespace BusinessEntities.Models
{
    public class ExerciseSetModel
    {
        public Guid exerciseSetId { get; set; }
        public Guid workoutId { get; set; }
        public ExerciseModel exercise { get; set; }
        public int sets { get; set; }
        public int targetReps { get; set; }
        public int targetRPE { get; set; }
        public int restPeriod { get; set; }
    }
}
