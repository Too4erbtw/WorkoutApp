using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using WorkoutApp.Domain;
namespace WorkoutApp.Application
{
    static class WorkoutValidator
    {
        public static void Validate(Workout workout)
        {
            if (string.IsNullOrWhiteSpace(workout.Type))
                throw new ArgumentException("Тип тренировки не может быть пустым");

            if (workout.Duration <= 0)
                throw new ArgumentException("Длительность должна быть больше 0");

            if (workout.Id <= 0)
                throw new ArgumentException("Id должен быть больше 0");

            if (workout.DateOfTraining < DateTime.Now)
                throw new ArgumentException("Дата тренировки не может быть в прошлом");
        }
    }

}
