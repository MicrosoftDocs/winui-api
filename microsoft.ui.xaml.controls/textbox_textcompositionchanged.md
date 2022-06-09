---
-api-id: E:Microsoft.UI.Xaml.Controls.TextBox.TextCompositionChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler TextCompositionChanged<Windows.UI.Xaml.Controls.TextBox,  Windows.UI.Xaml.Controls.TextCompositionChangedEventArgs>
-->

# Microsoft.UI.Xaml.Controls.TextBox.TextCompositionChanged

## -description

Occurs when text being composed through an Input Method Editor (IME) changes.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<TextBox TextCompositionChanged="eventhandler"/>
```

## -remarks

For event data, see [TextCompositionChangedEventArgs](textcompositionchangedeventargs.md).

This event occurs only when text is composed through an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)). Text composition events occur in the following order:

+ [TextCompositionStarted](textbox_textcompositionstarted.md)
+ [TextChanging](textbox_textchanging.md)
+ [TextChanged](textbox_textchanged.md)
+ TextCompositionChanged
+ [TextCompositionEnded](textbox_textcompositionended.md)

After the [TextCompositionStarted](textbox_textcompositionstarted.md) event, the [TextChanging](textbox_textchanging.md) &gt; [TextChanged](textbox_textchanged.md) &gt; TextCompositionChanged event cycle can occur multiple times before the [TextCompositionEnded](textbox_textcompositionended.md) event occurs.

## -examples

## -see-also

[TextCompositionChangedEventArgs](textcompositionchangedeventargs.md), [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10))
