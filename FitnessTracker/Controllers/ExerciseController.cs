using BusinessEntities.EF;
using BusinessEntities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Services;
using System.Diagnostics.Metrics;

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
        public async Task<ActionResult<List<ExerciseModel>>> GetExerciseList()
        {
            return Ok(await DL.GetExerciseList());
        }

        [HttpGet("ExerciseById/{exerciseId}")]
        public async Task<ActionResult<ExerciseModel>> GetExerciseById(Guid exerciseId)
        {
            return Ok(await DL.GetExerciseById(exerciseId));
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ExerciseModel>> PostExercise(string exerciseName)
        {
            var exercise = await DL.AddExercise(exerciseName);
            return CreatedAtAction(actionName: "GetExerciseById", routeValues: new { exerciseId = exercise.exerciseId }, exercise);
        }
    }
}
