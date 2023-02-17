using BusinessEntities.EF;
using BusinessEntities.Models;

namespace Services
{
    public class DL : IDL
    {
        private ClientDBContext db = new ClientDBContext();

        public List<Exercise> GetExerciseList()
        {
            List<Exercise> exerciseList = new List<Exercise>();
            try
            {
                exerciseList = db.Exercises.Select(e => new Exercise
                {
                    ExerciseId = e.ExerciseId,
                    ExerciseName = e.ExerciseName
                }).ToList();
            }
            catch (Exception ex)
            {
                
            }
            return exerciseList;
        }

        public Exercise GetExerciseById(string exerciseId)
        {
            Exercise exercise = new Exercise();

            try
            {
                exercise = db.Exercises.Select(e => new Exercise { ExerciseId = e.ExerciseId, ExerciseName = e.ExerciseName })
                    .FirstOrDefault(e => e.ExerciseId == exerciseId);
            }
            catch (Exception ex)
            {

            }
            return exercise;
        }

        public List<Exercise> GetExercisesByMuscle(string muscleId)
        {
            List<Exercise> exerciseList = new List<Exercise>();

            try
            {
                exerciseList = db.ExerciseMuscleMapping.Where(e => e.MuscleId == muscleId)
                    .Select(e => new Exercise { ExerciseId = e.ExerciseId, ExerciseName = e.Exercise.ExerciseName }).ToList();
            }
            catch (Exception ex)
            {

            }
            return exerciseList;
        }

        public List<Exercise> GetExercisesByBodyPart(string bodyPartId)
        {
            List<Exercise> exerciseList = new List<Exercise>();

            try
            {
                List<string> muscleIds = db.Muscles.Where(b => b.BodyPartId == bodyPartId).Select(e => e.MuscleId).ToList();
                exerciseList = db.ExerciseMuscleMapping.Where(e => muscleIds.Contains(e.MuscleId))
                    .Select(e => new Exercise { ExerciseId = e.ExerciseId, ExerciseName = e.Exercise.ExerciseName }).ToList();
            }
            catch (Exception ex)
            {

            }
            return exerciseList;
        }

        public List<Workout> GetWorkoutList()
        {
            List<Workout> workoutList = new List<Workout>();

            try
            {
                workoutList = db.Workouts.Select(w => new Workout { WorkoutId = w.WorkoutId, WorkoutName = w.WorkoutName }).ToList();
            }
            catch (Exception ex)
            {

            }
            return workoutList;
        }

        public Workout GetWorkoutById(int workoutId)
        {
            Workout workout = new Workout();

            try
            {
                var w = db.Workouts.FirstOrDefault(w => w.WorkoutId == workoutId);

                if (w != null)
                {
                    workout.WorkoutId = workoutId;
                    workout.WorkoutName = w.WorkoutName;

                    workout.ExerciseList = db.WorkoutExerciseMapping.Where(sem => sem.WorkoutId == workoutId)
                        .Select(e => new Exercise
                        {
                            ExerciseId = e.ExerciseId,
                            ExerciseName = e.Exercise.ExerciseName,
                            Reps = e.Reps,
                            Sets = e.Sets,
                            TargetRPE = e.TargetRpe,
                            RestPeriod = e.RestPeriod
                        }).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return workout;
        }


        public bool AddWorkout(Workout workout)
        {
            try
            {
                Workouts w = new Workouts
                {
                    WorkoutName = workout.WorkoutName
                };

                db.Workouts.Add(w);
                db.SaveChanges();
                
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
