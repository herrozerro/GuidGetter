using System;
using System.Reactive;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using GuidGetter.UI.Views;
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

        OpenCommand = ReactiveCommand.Create(() =>
        {
            if (Application.Current?.ApplicationLifetime is not IClassicDesktopStyleApplicationLifetime
                {
                    MainWindow.IsVisible: false
                } desktop) return;
            
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
            desktop.MainWindow.Show();
        });
    }

    public ReactiveCommand<Unit,Unit> ExitCommand { get; }

    public ReactiveCommand<Unit,Unit> OpenCommand { get; }
}