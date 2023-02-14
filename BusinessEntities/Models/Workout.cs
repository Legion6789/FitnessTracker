namespace BusinessEntities.Models
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public string WorkoutName { get; set; }
        public List<Exercise> ExerciseList { get; set; }
    }
}
