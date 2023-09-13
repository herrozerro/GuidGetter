using System;
using System.Reactive;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace GuidGetter.UI.ViewModels;

public class ApplicationViewModel : ViewModelBase
{
    public ApplicationViewModel()
    {
        ExitCommand = ReactiveCommand.Create(() =>
        {
            Console.WriteLine("Test");
            if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime lifetime)
            {
                Console.WriteLine("Test2");
                lifetime.Shutdown();
            }
        });

        ToggleCommand = ReactiveCommand.Create(() => { Console.WriteLine("Test3"); });
    }

    public ReactiveCommand<Unit,Unit> ExitCommand { get; }

    public ReactiveCommand<Unit,Unit> ToggleCommand { get; }
}