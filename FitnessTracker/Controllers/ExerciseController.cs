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
            //return DL.GetExerciseList(hashString);
            return new List<Exercise>();
        }

        [HttpGet("ExerciseById/{exerciseId}")]
        public Exercise GetExerciseById(Guid exerciseId)
        {
            //return DL.GetExerciseById(exerciseId);
            return new Exercise();
        }
    }
}
