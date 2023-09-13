using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GuidGetter.UI.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void BtnCopyGuid_OnClicktnCopyGuid_Click(object? sender, RoutedEventArgs e)
    {
        Clipboard?.SetTextAsync(TxtGuid.Text).Wait();
    }

    private void BtnGetGuid_OnClicktnGetGuid_Click(object? sender, RoutedEventArgs e)
    {
        TxtGuid.Text = Guid.NewGuid().ToString();
        Clipboard?.SetTextAsync(TxtGuid.Text).Wait();
    }

    private void BtnBlankGuid_OnClicknBlankGuid_Click(object? sender, RoutedEventArgs e)
    {
        TxtGuid.Text = Guid.Empty.ToString();
        Clipboard?.SetTextAsync(TxtGuid.Text).Wait();
    }
}