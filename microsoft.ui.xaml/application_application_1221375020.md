---
-api-id: M:Microsoft.UI.Xaml.Application.#ctor
-api-type: winrt constructor
---

<!-- Method syntax
public Application()
-->

# Microsoft.UI.Xaml.Application.Application

## -description

Initializes a new instance of the [Application](application.md) class.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

The [Application](application.md) object is typically provided in the initial XAML for App.xaml. The default project templates in Visual Studio generate an `App` class that derives from [Application](application.md). This class associates itself with the XAML by calling the generated `InitializeComponent` method in its constructor. You can add additional initialization code to the `App` constructor, but you will typically only add code to associate handlers to [Application](application.md) events. For other initialization code, you should override one or more initialization methods such as [OnLaunched](application_onlaunched_1344752508.md).

This property (and the static [Current](application_current.md) property) returns a [Window](window.md) object. From this object, an app can use the [Dispatcher](window_dispatcher.md) object or determine the size of the Window from the [Bounds](window_bounds.md) property.

Typically, Window is used to set a [UIElement](uielement.md) to the [Content](window_content.md) that represents the app UI. This is usually done as part of app activation (for example in the [OnLaunched](application_onlaunched_1344752508.md) override) and allows you to change the window content throughout the lifetime of the window.

## -examples

## -see-also
