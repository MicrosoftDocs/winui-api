---
-api-id: M:Microsoft.UI.Xaml.Application.OnFileOpenPickerActivated(Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnFileOpenPickerActivated(Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs args)
-->

# Microsoft.UI.Xaml.Application.OnFileOpenPickerActivated

## -description

Invoked when a UWP application is activated through file-open dialog association. This event is not invoked by desktop applications.

## -parameters

### -param args

Event data for the event.

## -remarks

OnFileOpenPickerActivated is a pre-defined activation point handler that is invoked for a core [Activated](/uwp/api/windows.ui.core.corewindow.activated) event when the [ActivationKind](/uwp/api/windows.applicationmodel.activation.activationkind) is **FileOpenPicker**.

All [Application](application.md) overrides involved in an activation scenario should call [Window.Activate](window_activate_1797342875.md) in their implementations.

## -examples

## -see-also

[OnActivated](application_onactivated_603737819.md), [ActivationKind](/uwp/api/windows.applicationmodel.activation.activationkind), [Handle app activation](/windows/uwp/launch-resume/activate-an-app), [Association launching sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AssociationLaunching), [Launching and resuming apps](/windows/uwp/launch-resume/)
