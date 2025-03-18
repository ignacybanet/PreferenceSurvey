using Avalonia.Controls;
using Avalonia.Interactivity;

namespace PreferenceSurvey;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
    }

    public void FirstSubmit(object? sender, RoutedEventArgs e)
    {
        UsernameSubmit.Text = $"Nazwa użytkownika: {Username.Text}";
    }
}