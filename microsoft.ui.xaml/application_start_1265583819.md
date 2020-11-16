---
-api-id: M:Microsoft.UI.Xaml.Application.Start(Microsoft.UI.Xaml.ApplicationInitializationCallback)
-api-type: winrt method
---

<!-- Method syntax
public void Start(Windows.UI.Xaml.ApplicationInitializationCallback callback)
-->

# Microsoft.UI.Xaml.Application.Start

## -description
Provides the entry point and requests initialization of the application. Use the callback to instantiate the [Application](application.md) class.


## -parameters
### -param callback
The callback that should be invoked during the initialization sequence.

## -remarks
In a Desktop app this will run a message pump internally, and not return until the application 
shuts down. In a UWP app it will return immediately.

Typically, you will not need to call this method directly. If you use Visual Studio to develop your apps, the build system will generate code that includes the necessary call for you.

The callback runs in the same thread as the main view.

## -examples

## -see-also
