---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.ButtonBase.ClickMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ClickMode ClickMode { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Primitives.ButtonBase.ClickMode

## -description
Gets or sets a value that indicates when the [Click](buttonbase_click.md) event occurs, in terms of device behavior.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<button ClickMode="clickModeMemberName"/>

```


## -xaml-values
<dl><dt>clickModeMemberName</dt><dd>clickModeMemberNameA named constant of the ClickMode enumeration, such as Hover.</dd>
</dl>
## -property-value
A value of the enumeration that indicates when the [Click](buttonbase_click.md) event occurs.
<!-- AFAIK it is not useful to hint a default value. Templates change it, and there also appears to be runtime tweaking of the value in response to things like equivalent key handling.-->

## -remarks

## -examples
The following example shows three buttons that respond to clicks in three different ways based on their ClickMode property value.


+ Hover - When the mouse pointer hovers over the first button, the foreground color of the button changes.
+ Press - When the left mouse button is pressed while over the second button, the foreground color of the button changes.
+ Release - When the mouse button is pressed and released while over the third button, the button resets the foreground color of the other two buttons to their original color.




[!code-xaml[1](../microsoft.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/csharp/Page.xaml#Snippet1)]


[!code-csharp[11](../microsoft.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/csharp/Page.xaml.cs#Snippet11)]

[!code-vb[11](../microsoft.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/vbnet/Page.xaml.vb#Snippet11)]

## -see-also
[Button](../microsoft.ui.xaml.controls/button.md)

