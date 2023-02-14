using BusinessEntities.EF;
using BusinessEntities.Models;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace FitnessTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExerciseController : ControllerBase
    {
        private readonly IDL DL;
        private readonly ILogger<ExerciseController> logger;

        public ExerciseController(IDL dL, ILogger<ExerciseController> logger)
        {
            DL = dL;
            this.logger = logger;
        }

        [HttpGet("ExerciseList")]
        public List<Exercise> GetExerciseList()
        {
            return DL.GetExerciseList();
        }

        [HttpGet("ExerciseById/{exerciseId}")]
        public Exercise GetExerciseById(string exerciseId)
        {
            return DL.GetExerciseById(exerciseId);
        }

        [HttpGet("ExerciseByMuscle/{muscleId}")]
        public List<Exercise> GetExercisesByMuscle(string muscleId)
        {
            return DL.GetExercisesByMuscle(muscleId);
        }

        [HttpGet("ExerciseByBodyPart/{bodyPartId}")]
        public List<Exercise> GetExercisesByBodyPart(string bodyPartId)
        {
            return DL.GetExercisesByBodyPart(bodyPartId);
        }
    }
}
