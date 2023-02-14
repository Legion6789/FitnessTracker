using BusinessEntities.EF;
using BusinessEntities.Models;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace FitnessTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkoutController : ControllerBase
    {
        private readonly IDL DL;
        private readonly ILogger<WorkoutController> logger;

        public WorkoutController(IDL dL, ILogger<WorkoutController> logger)
        {
            DL = dL;
            this.logger = logger;
        }

        [HttpGet("WorkoutList")]
        public List<Workout> GetWorkoutList()
        {
            return DL.GetWorkoutList();
        }

        [HttpGet("WorkoutById/{workoutId}")]
        public Workout GetWorkoutById(int workoutId)
        {
            return DL.GetWorkoutById(workoutId);
        }
    }
}