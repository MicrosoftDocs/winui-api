---
-api-id: M:Microsoft.UI.Xaml.Application.Start(Microsoft.UI.Xaml.ApplicationInitializationCallback)
-api-type: winrt method
---

<!-- Method syntax
public void Start(Windows.UI.Xaml.ApplicationInitializationCallback callback)
-->

# Microsoft.UI.Xaml.Application.Start

## -description

Provides the entry point and requests initialization of the application. Use the specified [ApplicationInitializationCallback](applicationinitializationcallback.md) to instantiate the [Application](application.md) class.

## -parameters

### -param callback

The callback that should be invoked during the initialization sequence.

## -remarks

In a Desktop app this runs a message pump internally, and does not return until the application shuts down. In a UWP app it returns immediately.

Typically, you do not need to call this method directly. For example, in Visual Studio, the build system generates code that makes the call.

The callback runs in the same thread as the main view.

## -examples

## -see-also
