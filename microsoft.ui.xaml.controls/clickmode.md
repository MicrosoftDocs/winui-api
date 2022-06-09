---
-api-id: T:Microsoft.UI.Xaml.Controls.ClickMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.ClickMode : int
-->

# ClickMode

## -description
Specifies when the [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event should be raised for a control.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field Release:0
Specifies that the [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event should be raised when the left mouse button is pressed and released, and the mouse pointer is over the control. If you are using the keyboard, specifies that the [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event should be raised when the SPACEBAR or ENTER key is pressed and released, and the control has keyboard focus.

### -field Press:1
Specifies that the [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event should be raised when the mouse button is pressed and the mouse pointer is over the control. If you are using the keyboard, specifies that the [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event should be raised when the SPACEBAR or ENTER key is pressed and the control has keyboard focus.

### -field Hover:2
Specifies that the [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event should be raised when the mouse pointer moves over the control.


## -remarks

## -examples
The following example demonstrates the ClickMode enumeration.


+ Hover - When the mouse pointer hovers over the first button, the foreground color of the button changes.
+ Press - When the left mouse button is pressed while over the second button, the foreground color of the button changes.
+ Release - When the mouse button is pressed and released while over the third button, the button resets the foreground color of the other two buttons to their original color.




[!code-xaml[1](../microsoft.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/csharp/Page.xaml#Snippet1)]


[!code-csharp[11](../microsoft.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/csharp/Page.xaml.cs#Snippet11)]

[!code-vb[11](../microsoft.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/vbnet/Page.xaml.vb#Snippet11)]

## -see-also
