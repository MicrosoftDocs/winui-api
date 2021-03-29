---
-api-id: M:Microsoft.UI.Xaml.Application.OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Application.OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs)

<!--
protected virtual void OnLaunched (Microsoft.UI.Xaml.LaunchActivatedEventArgs args);
-->

## -description

Invoked when the application is launched. Override this method to perform application initialization and to display initial content in the associated window (UWP apps) or to create a new window (desktop apps).

## -parameters

### -param args

## -remarks

This method is typically created automatically when a project is created. You can then modify it or remove it.

## -see-also

[LaunchActivatedEventArgs](launchactivatedeventargs.md), [Launching and resuming apps](/windows/uwp/launch-resume/)

## -examples

In a desktop app, use OnLaunched to create the main window and pass it the first command line argument.

[!code-csharp[DesktopOnLaunchedSample](../microsoft.ui.xaml/code/Application_OnLaunchedSample/MainPage.xaml.cs#SnippetDesktopOnLaunchedSample)]

In a UWP app, use OnLaunched to display some initial content.

[!code-csharp[UWPOnLaunchedSample](../microsoft.ui.xaml/code/Application_OnLaunchedSample/MainPage.xaml.cs#SnippetUWPOnLaunchedSample)]
