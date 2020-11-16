---
-api-id: M:Microsoft.UI.Xaml.Application.OnSearchActivated(Windows.ApplicationModel.Activation.SearchActivatedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnSearchActivated(Windows.ApplicationModel.Activation.SearchActivatedEventArgs args)
-->

# Microsoft.UI.Xaml.Application.OnSearchActivated

## -description
Invoked when the application is activated through a search association.

## -parameters
### -param args
Event data for the event.

## -remarks
OnSearchActivated is a pre-defined activation point handler that is invoked for a core [Activated](/uwp/api/windows.ui.core.corewindow.activated) event when the [ActivationKind](/uwp/api/windows.applicationmodel.activation.activationkind) is **Search**.

All [Application](application.md) overrides involved in an activation scenario should call [Window.Activate](window_activate_1797342875.md) in their implementations.

The [Search contract sample](https://code.msdn.microsoft.com/windowsapps/Search-app-contract-sample-118a92f5) demonstrates how to respond to a [Search](/uwp/api/windows.applicationmodel.activation.activationkind) activated event.

Consider writing your OnSearchActivated handler as asynchronous. For more info, see [Minimize startup time](/previous-versions/windows/apps/hh994639(v=win.10)).

## -examples

## -see-also
[Quickstart: Adding search](/previous-versions/windows/apps/hh465238(v=win.10)), [Search contract sample](https://code.msdn.microsoft.com/windowsapps/Search-app-contract-sample-118a92f5)
