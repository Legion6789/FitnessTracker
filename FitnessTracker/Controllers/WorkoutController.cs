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
            DL.logger = logger;
        }

        [HttpGet("WorkoutList")]
        public object GetWorkoutList()
        {
            //return DL.GetWorkoutList(hashString);
            return new List<WorkoutTemplate>();
        }

        //[HttpGet("WorkoutById/{workoutId}")]
        [HttpGet("WorkoutById")]
        public WorkoutTemplate GetWorkoutById(int workoutId)
        {
            //return DL.GetWorkoutById(workoutId);
            return new WorkoutTemplate();
        }

        [HttpPost("AddWorkout")]
        public bool PostAddWorkout(WorkoutTemplate workout)
        {
            //return DL.AddWorkout(workout);
            return true;
        }
    }
}