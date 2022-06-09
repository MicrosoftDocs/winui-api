---
-api-id: E:Microsoft.UI.Xaml.UIElement.AccessKeyDisplayRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AccessKeyDisplayRequested<Windows.UI.Xaml.UIElement,  Windows.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs>
-->

# Microsoft.UI.Xaml.UIElement.AccessKeyDisplayRequested

## -description

Occurs when the user requests that access keys be displayed.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<uiElement AccessKeyDisplayRequested="eventhandler"/>
```

## -remarks

This event notifies an element to show access key visuals.

This event is not raised if the element is under an element with its [Visibility](uielement_visibility.md) property set to **Collapsed**.

## -examples

## -see-also

[AccessKeyDisplayDismissedEventArgs](../windows.ui.xaml.input/accesskeydisplarequestedeventargs.md), [Access keys](/windows/apps/design/input/access-keys)
