

namespace WorkoutApp.Domain;

class Workout
{
    public string? Comment { get; }
    public string Type { get; }
    public int Id { get; }
    public int Duration { get; }
    public DateTime DateOfTraining { get; }

    public Workout(string? comment, string type, int id, int duration, DateTime dateOfTraining)
    {
        Comment = comment;
        Type = type;
        Id = id;
        Duration = duration;
        DateOfTraining = dateOfTraining;
    }
}
