---
-api-id: M:Microsoft.UI.Xaml.Controls.RefreshRequestedEventArgs.GetDeferral
-api-type: winrt method
---
<!-- Method syntax.
public Deferral RefreshRequestedEventArgs.GetDeferral()
-->

# Microsoft.UI.Xaml.Controls.RefreshRequestedEventArgs.GetDeferral


## -description

Gets a deferral object for managing the work done in the RefreshRequested event handler.


**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -returns

A deferral object.


## -remarks

A deferral should be used if any asynchronous work is being done in the RefreshRequested event handler, so that the next event in the sequence isn't raised until this work is completed.


## -see-also


## -examples


