using System;

namespace WorkoutTracker.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string ExerciseName { get; set; }
        public string MuscleGroup { get; set; }
        public int Reps { get; set; }
        public int Weight { get; set; }
        public DateTime Date { get; set; }
    }
}
