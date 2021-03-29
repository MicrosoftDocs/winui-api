---
-api-id: M:Microsoft.UI.Xaml.Application.OnWindowCreated(Microsoft.UI.Xaml.WindowCreatedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnWindowCreated(Windows.UI.Xaml.WindowCreatedEventArgs args)
-->

# Microsoft.UI.Xaml.Application.OnWindowCreated

## -description

Invoked when a UWP application creates a window. This event is not invoked by desktop applications.

## -parameters

### -param args

Event data for the event. The WindowCreatedEventArgs contains the Window object.

## -remarks

In **UWP apps**, this method is called once for the creation of the main window, once for each hosted window, 
and once each time [CreateNewView](/uwp/api/windows.applicationmodel.core.coreapplication.createnewview) is called. You can override this method, for example, to access various panes by calling **GetForCurrentView** methods such as [SearchPane.GetForCurrentView](/uwp/api/windows.applicationmodel.search.searchpane.getforcurrentview) and [SettingsPane.GetForCurrentView](/uwp/api/windows.ui.applicationsettings.settingspane.getforcurrentview).

## -examples

## -see-also
