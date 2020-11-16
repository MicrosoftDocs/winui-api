---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.ButtonBase
-api-type: winrt class
---

<!-- Class syntax.
public class ButtonBase : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.Primitives.IButtonBase
-->

# Microsoft.UI.Xaml.Controls.Primitives.ButtonBase

## -description
Represents the base class for all button controls, such as [Button](../microsoft.ui.xaml.controls/button.md), [RepeatButton](repeatbutton.md), and [HyperlinkButton](../microsoft.ui.xaml.controls/hyperlinkbutton.md).

## -remarks
### **ButtonBase** derived classes

ButtonBase is the parent class for several immediately derived controls that refine specific button behaviors for UI interaction:

+ [Button](../microsoft.ui.xaml.controls/button.md)
+ [HyperlinkButton](../microsoft.ui.xaml.controls/hyperlinkbutton.md)
+ [RepeatButton](repeatbutton.md)
+ [ToggleButton](togglebutton.md) (parent of [RadioButton](../microsoft.ui.xaml.controls/radiobutton.md), [AppBarToggleButton](../microsoft.ui.xaml.controls/appbartogglebutton.md), [CheckBox](../microsoft.ui.xaml.controls/checkbox.md))


## -examples
The following example demonstrates handling the [Click](buttonbase_click.md) event and setting the [IsEnabled](../microsoft.ui.xaml.controls/control_isenabled.md) property of a [Button](../microsoft.ui.xaml.controls/button.md), which inherits from ButtonBase.



[!code-xaml[4](../microsoft.ui.xaml/code/System.Windows.Controls.ButtonClickEx/csharp/Page.xaml#Snippet4)]


[!code-csharp[41](../microsoft.ui.xaml/code/System.Windows.Controls.ButtonClickEx/csharp/Page.xaml.cs#Snippet41)]

[!code-vb[41](../microsoft.ui.xaml/code/System.Windows.Controls.ButtonClickEx/vbnet/Page.xaml.vb#Snippet41)]

## -see-also
[ContentControl](../microsoft.ui.xaml.controls/contentcontrol.md)
lso
[ContentControl](../microsoft.ui.xaml.controls/contentcontrol.md)
