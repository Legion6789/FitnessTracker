using BusinessEntities.EF;
using BusinessEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Tools;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Services
{
    public class DL : IDL
    {
        private ClientDBContext db = new ClientDBContext();
        public ILogger logger { get; set; }

        public async Task<List<ExerciseModel>> GetExerciseList()
        {
            List<ExerciseModel> exerciseList = new List<ExerciseModel>();

            try
            {
                exerciseList = await db.Exercise.Select(e => new ExerciseModel
                {
                    exerciseId = e.ExerciseId,
                    exerciseName = e.ExerciseName
                }).OrderBy(e => e.exerciseName).ToListAsync();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }

            //if (serverHashString == getUnescapedHashString(clientHashString))
            //{
            //    return new { ExerciseList = new List<Exercise>(), HashString = serverHashString, NeedsUpdate = 0 };
            //}
            //else
            //{
            //    return new { ExerciseList = exerciseList, HashString = serverHashString, NeedsUpdate = 1 };
            //}

            return exerciseList;
        }

        private string getUnescapedHashString(string hbs)
        {
            return System.Text.RegularExpressions.Regex.Unescape(hbs);
        }

        private string getHashString(object o)
        {
            string oString = JsonSerializer.Serialize(o);
            byte[] bytes = Encoding.UTF8.GetBytes(oString);

            SHA256 sha256 = SHA256.Create();

            byte[] hashBytes = sha256.ComputeHash(bytes);

            return Encoding.UTF8.GetString(hashBytes);
        }

        public async Task<ExerciseModel> GetExerciseById(Guid exerciseId)
        {
            ExerciseModel exercise = new ExerciseModel();

            try
            {
                exercise = await db.Exercise.Select(e => new ExerciseModel { exerciseId = e.ExerciseId, exerciseName = e.ExerciseName }).FirstOrDefaultAsync(e => e.exerciseId == exerciseId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }

            return exercise;
        }

        public async Task<ExerciseModel> AddExercise(string exerciseName)
        {
            ExerciseModel exercise = new ExerciseModel();

            try
            {
                var newExercise = new Exercise() { ExerciseId = Guid.NewGuid(), ExerciseName = exerciseName };
                await db.Exercise.AddAsync(newExercise);
                await db.SaveChangesAsync();
                
                exercise.exerciseId = newExercise.ExerciseId;
                exercise.exerciseName = newExercise.ExerciseName;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }

            return exercise;
        }

        public object GetWorkoutList()
        {
            List<WorkoutTemplateModel> workoutList = new List<WorkoutTemplateModel>();
            //string serverHashString = "";

            //try
            //{
            //    workoutList = db.Workouts.Select(w => new Workout { WorkoutId = w.WorkoutId, WorkoutName = w.WorkoutName }).ToList();
            //    serverHashString = getHashString(workoutList);
            //}
            //catch (Exception ex)
            //{
            //    logger.LogError(ex, ex.Message);
            //}

            //if (serverHashString == getUnescapedHashString(clientHashString))
            //{
            //    return new { WorkoutList = new List<Workout>(), HashString = serverHashString, NeedsUpdate = 0 };
            //}
            //else
            //{
            //    return new { WorkoutList = workoutList, HashString = serverHashString, NeedsUpdate = 1 };
            //}

            return workoutList;
        }

        public WorkoutTemplateModel GetWorkoutById(Guid workoutId)
        {
            WorkoutTemplateModel workout = new WorkoutTemplateModel();

            //try
            //{
            //    var w = db.Workouts.FirstOrDefault(w => w.WorkoutId == workoutId);

            //    if (w != null)
            //    {
            //        workout.WorkoutId = workoutId;
            //        workout.WorkoutName = w.WorkoutName;

            //        workout.ExerciseList = db.WorkoutExerciseMapping.Where(sem => sem.WorkoutId == workoutId)
            //            .Select(e => new Exercise
            //            {
            //                ExerciseId = e.ExerciseId,
            //                ExerciseName = e.Exercise.ExerciseName,
            //                Reps = e.Reps,
            //                Sets = e.Sets,
            //                TargetRPE = e.TargetRpe,
            //                RestPeriod = e.RestPeriod
            //            }).ToList();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    logger.LogError(ex, ex.Message);
            //}
            return workout;
        }


        public bool AddWorkout(WorkoutTemplateModel workout)
        {
            //try
            //{
            //    Workouts w = new Workouts
            //    {
            //        WorkoutName = workout.WorkoutName
            //    };

            //    db.Workouts.Add(w);
            //    db.SaveChanges();
                
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    logger.LogError(ex, ex.Message);
            //}
            return false;
        }
    }
}
