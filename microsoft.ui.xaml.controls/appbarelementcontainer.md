---
-api-id: T:Microsoft.UI.Xaml.Controls.AppBarElementContainer
-api-type: winrt class
---

<!-- Class syntax.
public class AppBarElementContainer : ContentControl, ContentControl, ICommandBarElement, ICommandBarElement2
-->

# Microsoft.UI.Xaml.Controls.AppBarElementContainer

## -description

Represents a container that allows an element that doesn't implement ICommandBarElement to be displayed in a command bar.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<AppBarButton .../>
```

## -remarks

In order to be added to the primary or secondary command collections of a command bar, an element must implement the [ICommandBarElement](icommandbarelement.md) interface. AppBarElementContainer is a wrapper that implements this interface so you can add an element to a command bar even if it doesn't implement the interface itself.

## -see-also

## -examples

