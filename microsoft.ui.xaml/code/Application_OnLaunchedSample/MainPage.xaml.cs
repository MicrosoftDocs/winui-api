using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Application_OnLaunchedSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        // <SnippetDesktopOnLaunchedSample>
        protected override void OnLaunched(MUX.LaunchActivatedEventArgs e)
        {
            MainWindow window = new MainWindow();

            if (e.Arguments != null)
            {
                string[] arguments = e.Arguments.Split(' ');
                // Assuming MainWindow' has a public property called FileName 
                window.FileName = arguments[0];
            }

            window.Activate();
        }

        //</SnippetDesktopOnLaunchedSample>

        // <SnippetUWPOnLaunchedSample>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            MainPage page = new MainPage();

            if (e.Arguments != null)
            {
                string[] arguments = e.Arguments.Split(' ');
                // Assuming MainWindow' has a public property called FileName 
                page.FileName = arguments[0];
            }

            Window.Current.Content = page;
            Window.Current.Activate();
            window.Activate();
        }
        //</SnippetUWPOnLaunchedSample>
    }
}
