---
-api-id: M:Microsoft.UI.Xaml.Application.OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Application.OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs)

<!--
protected virtual void OnLaunched (Microsoft.UI.Xaml.LaunchActivatedEventArgs args);
-->


## -description
Invoked when the application is launched. Override this method to perform application initialization 
and to display initial content in the associated Window (UWP apps) or create a new Window (Desktop apps).
## -parameters

### -param args

## -remarks
This method is typically created automatically when a project is created. 
You can then modify it or remove it.
## -see-also

## -examples
In a Desktop app, use OnLaunched to create the main window and pass it the first command line argument.

```csharp
protected override void OnLaunched(MUX.LaunchActivatedEventArgs e)
{
     MainWindow window = new MainWindow();
     
     if(e.Arguments != null)
     {
        string[] arguments = e.Arguments.Split(' ');
	// Assuming MainWindow' has a public property called FileName 
        window.FileName = arguments[0];
     }	

     window.Activate();
}
```

In a UWP app,

```csharp
protected override void OnLaunched(LaunchActivatedEventArgs e)
{
     MainPage page = new MainPage();
     
     if(e.Arguments != null)
     {
        string[] arguments = e.Arguments.Split(' ');
	// Assuming MainWindow' has a public property called FileName 
        page.FileName = arguments[0];
     }	

    Window.Current.Content = page;
    Window.Current.Activate();
    window.Activate();
}
```

