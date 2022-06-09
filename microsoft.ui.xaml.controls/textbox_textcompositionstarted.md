---
-api-id: E:Microsoft.UI.Xaml.Controls.TextBox.TextCompositionStarted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler TextCompositionStarted<Windows.UI.Xaml.Controls.TextBox,  Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs>
-->

# Microsoft.UI.Xaml.Controls.TextBox.TextCompositionStarted

## -description

Occurs when a user starts composing text through an Input Method Editor (IME).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<TextBox TextCompositionStarted="eventhandler"/>
```

## -remarks

For event data, see [TextCompositionStartedEventArgs](textcompositionstartedeventargs.md).

This event occurs only when text is composed through an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)). Text composition events occur in the following order:

+ TextCompositionStarted
+ [TextChanging](textbox_textchanging.md)
+ [TextChanged](textbox_textchanged.md)
+ [TextCompositionChanged](textbox_textcompositionchanged.md)
+ [TextCompositionEnded](textbox_textcompositionended.md)

After the TextCompositionStarted event, the [TextChanging](textbox_textchanging.md) &gt; [TextChanged](textbox_textchanged.md) &gt; [TextCompositionChanged](textbox_textcompositionchanged.md) event cycle can occur multiple times before the [TextCompositionEnded](textbox_textcompositionended.md) event occurs.

## -examples

## -see-also

[TextCompositionStartedEventArgs](textcompositionstartedeventargs.md), [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10))
