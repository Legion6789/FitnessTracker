using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IDL
    {
        object GetExerciseList(string clientHashString);
        Exercise GetExerciseById(string exerciseId);
        List<Exercise> GetExercisesByMuscle(string muscleId);
        List<Exercise> GetExercisesByBodyPart(string bodyPartId);
        List<Workout> GetWorkoutList();
        Workout GetWorkoutById(int workoutId);
        bool AddWorkout(Workout workout);
    }
}
