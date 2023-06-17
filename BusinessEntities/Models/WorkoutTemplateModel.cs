namespace BusinessEntities.Models
{
    public class WorkoutTemplateModel
    {
        public Guid workoutId { get; set; }
        public string workoutName { get; set; }
        public bool isDeleted { get; set; }
        public List<ExerciseModel> ExerciseList { get; set; }
    }
}
