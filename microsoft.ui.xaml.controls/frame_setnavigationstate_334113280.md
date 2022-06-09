---
-api-id: M:Microsoft.UI.Xaml.Controls.Frame.SetNavigationState(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void SetNavigationState(System.String navigationState)
-->

# Microsoft.UI.Xaml.Controls.Frame.SetNavigationState

## -description
Reads and restores the navigation history of a [Frame](frame.md) from a provided serialization string.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param navigationState
The serialization string that supplies the restore point for navigation history.

## -remarks
This method is useful to restore the navigation state of your app after it has been suspended and resumed. When your app is suspended, call [GetNavigationState](frame_getnavigationstate_1352043812.md) and save the return value. When your app is resumed, call [SetNavigationState](/uwp/api/windows.ui.xaml.controls.frame.setnavigationstate) and pass it the saved value.

Calling [SetNavigationState](/uwp/api/windows.ui.xaml.controls.frame.setnavigationstate) will call [Page.OnNavigatedTo](page_onnavigatedto_1316593960.md) for the current page, with **NavigationMode.Back**. [SetNavigationState](/uwp/api/windows.ui.xaml.controls.frame.setnavigationstate) is usually called when the application is being resumed, so the current page is navigated to.

## -examples

## -see-also
