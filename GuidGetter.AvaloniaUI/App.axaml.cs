using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using GuidGetter.UI.ViewModels;
using GuidGetter.UI.Views;

namespace GuidGetter.UI;

public partial class App : Application
{
    public App()
    {
        DataContext = new ApplicationViewModel();
    }
    
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
        }
        
        base.OnFrameworkInitializationCompleted();
    }
}