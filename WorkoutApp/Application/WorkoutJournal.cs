using System;
using System.Collections.Generic;
using System.Text;
using WorkoutApp.Domain;
namespace WorkoutApp.Application
{
    class WorkoutJournal
    {
        private readonly List<Workout> Workouts = new();

        public void AddWorkout(Workout workout)
        {
            WorkoutValidator.Validate(workout);
            Workouts.Add(workout);
        }

        public bool RemoveWorkout(int id)
        {
            var workout = Workouts.FirstOrDefault(w => w.Id == id);
            if (workout == null)
                return false;

            Workouts.Remove(workout);
            return true;
        }

        public List<Workout> GetAllWorkouts()
        {
            return new List<Workout>(Workouts);
        }

        public List<Workout> FindWorkoutsByType(string type)
        {
            return Workouts
                .Where(w => w.Type == type)
                .ToList();
        }

        public List<Workout> FindWorkoutsAtRange(DateTime start, DateTime end)
        {
            return Workouts
                .Where(w => w.DateOfTraining >= start && w.DateOfTraining <= end)
                .ToList();
        }
    }

}
