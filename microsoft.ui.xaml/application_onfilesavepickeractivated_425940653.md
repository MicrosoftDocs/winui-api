---
-api-id: M:Microsoft.UI.Xaml.Application.OnFileSavePickerActivated(Windows.ApplicationModel.Activation.FileSavePickerActivatedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnFileSavePickerActivated(Windows.ApplicationModel.Activation.FileSavePickerActivatedEventArgs args)
-->

# Microsoft.UI.Xaml.Application.OnFileSavePickerActivated

## -description

Invoked when a UWP application is activated through file-save dialog association. This event is not invoked by desktop applications.

## -parameters

### -param args

Event data for the event.

## -remarks

OnFileSavePickerActivated is a pre-defined activation point handler that is invoked for a core [Activated](/uwp/api/windows.ui.core.corewindow.activated) event when the [ActivationKind](/uwp/api/windows.applicationmodel.activation.activationkind) is **FileSavePicker**. This occurs when the user saves a file through the file picker and selects the app as the location.

All [Application](application.md) overrides involved in an activation scenario should call [Window.Activate](window_activate_1797342875.md) in their implementations.

For example code that shows an OnFileSavePickerActivated override, see [File picker contracts sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/File%20picker%20contracts%20sample).

## -examples

## -see-also

[OnActivated](application_onactivated_603737819.md), [FileSavePickerActivatedEventArgs](/uwp/api/windows.applicationmodel.activation.filesavepickeractivatedeventargs), [File picker contracts sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/File%20picker%20contracts%20sample), [Launching and resuming apps](/windows/uwp/launch-resume/)
