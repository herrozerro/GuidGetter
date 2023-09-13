using System;
using ReactiveUI;

namespace GuidGetter.UI.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    public string RandomGuid => Guid.NewGuid().ToString();

    private bool isVisible;
    public bool IsVisible
    {
        get => isVisible;
        set => this.RaiseAndSetIfChanged(ref isVisible, value);
    }
}