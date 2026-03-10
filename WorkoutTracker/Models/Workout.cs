using System;

namespace WorkoutTracker.Models
{
    public class Workout
    {
        public int Id { get; set; }              // PK
        public string ExerciseName { get; set; } // e.g., "Bench Press"
        public string MuscleGroup { get; set; }  // e.g., "Chest"
        public int Reps { get; set; }
        public int Weight { get; set; }          // lbs or kg
        public DateTime Date { get; set; }
    }
}
