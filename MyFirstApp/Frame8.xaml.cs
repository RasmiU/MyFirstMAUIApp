namespace MyFirstApp;

public partial class Frame8 : ContentPage
{
    List<Reminder> reminders;

    public Frame8()
    {
        InitializeComponent();
        reminders = new List<Reminder>()
        {
            new Reminder()
            {
                 Name = "Have food.",
                 Description = "Have food on time.",
                 Time = "3 times a day."
            },
            new Reminder()
            {
                Name = "Have meds.",
                Description = "Have meds on time.",
                Time = "3 times a day."
            },
            new Reminder()
            {
                Name = "Exercise.",
                Description = "Exercise daily.",
                Time = "Exercise atleast once a day."
            }
        };
        for (int i = 0; i < 100; i++)
        {

            reminders.Add(new Reminder()
            {
                Name = $"Have food.{i}",
                Description = "Have food on time.",
                Time = "3 times a day."
            });
        }
        MainCV.ItemsSource = reminders;
    }
}