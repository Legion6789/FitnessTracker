using BusinessEntities.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IDL
    {
        ILogger logger { get; set; }
        object GetExerciseList();
        ExerciseModel GetExerciseById(Guid exerciseId);
        object GetWorkoutList();
        WorkoutTemplateModel GetWorkoutById(Guid workoutId);
        bool AddWorkout(WorkoutTemplateModel workout);
    }
}
