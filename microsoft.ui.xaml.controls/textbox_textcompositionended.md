---
-api-id: E:Microsoft.UI.Xaml.Controls.TextBox.TextCompositionEnded
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler TextCompositionEnded<Windows.UI.Xaml.Controls.TextBox,  Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs>
-->

# Microsoft.UI.Xaml.Controls.TextBox.TextCompositionEnded

## -description

Occurs when a user stops composing text through an Input Method Editor (IME).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<TextBox TextCompositionEnded="eventhandler"/>
```

## -remarks

For event data, see [TextCompositionEndedEventArgs](textcompositionendedeventargs.md).

This event occurs only when text is composed through an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)). Text composition events occur in the following order:

+ [TextCompositionStarted](textbox_textcompositionstarted.md)
+ [TextChanging](textbox_textchanging.md)
+ [TextChanged](textbox_textchanged.md)
+ [TextCompositionChanged](textbox_textcompositionchanged.md)
+ TextCompositionEnded

After the [TextCompositionStarted](textbox_textcompositionstarted.md) event, the [TextChanging](textbox_textchanging.md) &gt; [TextChanged](textbox_textchanged.md) &gt; [TextCompositionChanged](textbox_textcompositionchanged.md) event cycle can occur multiple times before the TextCompositionEnded event occurs.

## -examples

## -see-also

[TextCompositionEndedEventArgs](textcompositionendedeventargs.md), [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10))
