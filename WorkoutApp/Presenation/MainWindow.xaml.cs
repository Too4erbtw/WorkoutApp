using System;
using System.Windows;
using WorkoutApp.Application;
using WorkoutApp.Domain;

namespace WorkoutApp.Presentation;

public partial class MainWindow : Window
{
    private readonly WorkoutJournal _journal = new();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddWorkout_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            string type = TypeTextBox.Text;
            string comment = CommentTextBox.Text;

            int id = int.Parse(IdTextBox.Text);
            int duration = int.Parse(DurationTextBox.Text);
            DateTime date = DateTime.Parse(DateTextBox.Text);

            var workout = new Workout(comment, type, id, duration, date);
            _journal.AddWorkout(workout);

            ResultTextBlock.Text = "Тренировка добавлена";
            ResultTextBlock.Foreground = System.Windows.Media.Brushes.Green;
        }
        catch (Exception ex)
        {
            ResultTextBlock.Text = ex.Message;
            ResultTextBlock.Foreground = System.Windows.Media.Brushes.Red;
        }
    }
}
