namespace BusinessEntities.Models
{
    [Serializable]
    public class Exercise
    {
        public string ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int? TargetRPE { get; set; }
        public Decimal? RestPeriod { get; set; }
    }
}
