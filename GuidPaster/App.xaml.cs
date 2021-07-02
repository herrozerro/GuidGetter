using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Indieteur.GlobalHooks;

namespace GuidPaster
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static GlobalKeyHook GlobalKeyHook = null;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            GlobalKeyHook = new GlobalKeyHook();
            GlobalKeyHook.OnKeyDown += OpenGuidGenerator;


            // Create the startup window
            MainWindow wnd = new MainWindow();
            // Do stuff here, e.g. to the window
            wnd.Title = "Something else";
            // Show the window
            wnd.Show();
        }

        private static void OpenGuidGenerator(object sender, GlobalKeyEventArgs e)
        {
            if (e.Control != ModifierKeySide.None && e.Alt != ModifierKeySide.None && e.KeyCode == VirtualKeycodes.Q)
            {
                GuidGenerator guidGenerator = new GuidGenerator();
                guidGenerator.Show();
            }
        }
    }
}
