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

namespace GridSamples
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // <SnippetGridCsharpSample1>
        public MainPage()
        {
            this.InitializeComponent();
            LayoutDesign();
        }

        private void LayoutDesign()
        {
            //Create Stackpanel for ListBox Control and its description
            StackPanel DeptStackPanel = new StackPanel();
            DeptStackPanel.Margin = new Thickness(10);

            LayoutRoot.Children.Add(DeptStackPanel);
            Grid.SetColumn(DeptStackPanel, 1);
            Grid.SetRow(DeptStackPanel, 1);

            TextBlock DeptListHeading = new TextBlock();
            DeptListHeading.Text = "Department";

            ListBox DeptList = new ListBox();
            DeptList.Items.Add("Finance");
            DeptList.Items.Add("Marketing");
            DeptList.Items.Add("Human Resources");
            DeptList.Items.Add("Payroll");

            DeptStackPanel.Children.Add(DeptListHeading);
            DeptStackPanel.Children.Add(DeptList);

            //Create StackPanel for buttons
            StackPanel ButtonsStackPanel = new StackPanel();
            ButtonsStackPanel.Margin = new Thickness(10);
            ButtonsStackPanel.Orientation = Orientation.Horizontal;
            ButtonsStackPanel.HorizontalAlignment = HorizontalAlignment.Center;

            LayoutRoot.Children.Add(ButtonsStackPanel);
            Grid.SetColumn(ButtonsStackPanel, 0);
            Grid.SetRow(ButtonsStackPanel, 2);
            Grid.SetColumnSpan(ButtonsStackPanel, 2);

            Button BackButton = new Button();
            BackButton.Content = "Back";
            BackButton.Width = 100;

            Button CancelButton = new Button();
            CancelButton.Content = "Cancel";
            CancelButton.Width = 100;

            Button NextButton = new Button();
            NextButton.Content = "Next";
            NextButton.Width = 100;

            ButtonsStackPanel.Children.Add(BackButton);
            ButtonsStackPanel.Children.Add(CancelButton);
            ButtonsStackPanel.Children.Add(NextButton);

            BackButton.Margin = new Thickness(10);
            CancelButton.Margin = new Thickness(10);
            NextButton.Margin = new Thickness(10);
        }
    }

    // </SnippetGridCSharpSample1>
}
