﻿using BusinessEntities.Models;
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
        Task<List<ExerciseModel>> GetExerciseList();
        Task<ExerciseModel> GetExerciseById(Guid exerciseId);
        Task<ExerciseModel> AddExercise(string exerciseName);
        object GetWorkoutList();
        WorkoutTemplateModel GetWorkoutById(Guid workoutId);
        bool AddWorkout(WorkoutTemplateModel workout);
    }
}
