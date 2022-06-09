---
-api-id: E:Microsoft.UI.Xaml.UIElement.AccessKeyInvoked
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AccessKeyInvoked<Windows.UI.Xaml.UIElement,  Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs>
-->

# Microsoft.UI.Xaml.UIElement.AccessKeyInvoked

## -description

Occurs when a user completes an access key sequence.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<uiElement AccessKeyInvoked="eventhandler"/>
```

## -remarks

This event indicates that the action associated with the access key sequence should be invoked. For example, if an element’s [AccessKey](uielement_accesskey.md) is "A" and the user presses Alt-A.

An access key can have one or several characters. This event occurs only when users type all the characters of an access key. For example, if an [AccessKey](uielement_accesskey.md) value is "BC", the event doesn't occur when the user presses "B". The event occurs when the user presses "B", then "C".

This event occurs when the key is pressed, not when it's released.

## -examples

## -see-also

[AccessKeyInvokedEventArgs](../microsoft.ui.xaml.input/accesskeyinvokedeventargs.md), [Access keys](/windows/apps/design/input/access-keys)
