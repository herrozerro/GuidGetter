using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Hardcodet.Wpf.TaskbarNotification;
using Indieteur.GlobalHooks;

namespace GuidPaster
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static GlobalKeyHook GlobalKeyHook = null;
        public static GuidGenerator wndGuidGenerator = null;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            GlobalKeyHook = new GlobalKeyHook();
            GlobalKeyHook.OnKeyDown += OpenGuidGenerator;

            //TaskbarIcon tbi = new TaskbarIcon();
            //tbi.Icon = new System.Drawing.Icon("./Icons/Hammer.ico");
            //tbi.ToolTipText = "hello world";

            Taskbar window = new Taskbar();
            window.ShowInTaskbar = false;
            window.Show();
        }

        private static void OpenGuidGenerator(object sender, GlobalKeyEventArgs e)
        {
            if (e.Control != ModifierKeySide.None && e.Alt != ModifierKeySide.None && e.KeyCode == VirtualKeycodes.Q)
            {
                if (wndGuidGenerator == null)
                {
                    wndGuidGenerator = new GuidGenerator();
                    wndGuidGenerator.Closing += (a, b) => wndGuidGenerator = null;
                }
                wndGuidGenerator.Show();
            }
        }
    }
}
