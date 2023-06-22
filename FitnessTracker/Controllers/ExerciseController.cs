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
            DL.logger = logger;
        }

        [HttpGet("ExerciseList")]
        public object GetExerciseList()
        {
            //return new List<ExerciseModel> { new ExerciseModel { exerciseId = Guid.NewGuid(), exerciseName = "Bench Press" }, new ExerciseModel { exerciseId = Guid.NewGuid(), exerciseName = "Dude bro" } };
            return DL.GetExerciseList();
        }

        [HttpGet("ExerciseById/{exerciseId}")]
        public ExerciseModel GetExerciseById(Guid exerciseId)
        {
            return DL.GetExerciseById(exerciseId);
        }
    }
}
