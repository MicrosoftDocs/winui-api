---
-api-id: M:Microsoft.UI.Xaml.Controls.AutoSuggestBoxTextChangedEventArgs.CheckCurrent
-api-type: winrt method
---

<!-- Method syntax
public bool CheckCurrent()
-->

# Microsoft.UI.Xaml.Controls.AutoSuggestBoxTextChangedEventArgs.CheckCurrent

## -description
Returns a Boolean value indicating if the current value of the [TextBox](textbox.md) is unchanged from the point in time when the [TextChanged](autosuggestbox_textchanged.md) event was raised.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
Indicates if the current value of the [TextBox](textbox.md) is unchanged from the point in time when the [TextChanged](autosuggestbox_textchanged.md) event was raised.

## -remarks
This method is useful in determining if the text has changed since the event was raised, such as after obtaining suggestions from an asynchronous operation, in which time the user may have altered the text. Returns true if the text has not changed, false if it has.

## -examples

## -see-also
