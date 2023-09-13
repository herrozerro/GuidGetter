using System;

namespace GuidGetter.UI.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    public string RandomGuid => Guid.NewGuid().ToString();
}