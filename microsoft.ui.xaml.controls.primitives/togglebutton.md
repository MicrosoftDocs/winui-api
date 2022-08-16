---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.ToggleButton
-api-type: winrt class
---

<!-- Class syntax.
public class ToggleButton : Windows.UI.Xaml.Controls.Primitives.ButtonBase, Windows.UI.Xaml.Controls.Primitives.IToggleButton, Windows.UI.Xaml.Controls.Primitives.IToggleButtonOverrides
-->

# Microsoft.UI.Xaml.Controls.Primitives.ToggleButton

## -description
Represents a control that a user can select (check) or clear (uncheck). Base class for controls that can switch states, such as [CheckBox](../microsoft.ui.xaml.controls/checkbox.md) and [RadioButton](../microsoft.ui.xaml.controls/radiobutton.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ToggleButton .../>
-or-
<ToggleButton>
    singleObject
</ToggleButton>
-or-
<ToggleButton>contentString</ToggleButton>
```

## -remarks

ToggleButton can have three states:

| State | Property | Value |
|-------|----------|-------|
| checked | [IsChecked](togglebutton_ischecked.md) | **true** |
| unchecked | [IsChecked](togglebutton_ischecked.md) | **false** |
| indeterminate | [IsChecked](togglebutton_ischecked.md) | **null** |

 For the ToggleButton to report the indeterminate state, you must set the [IsThreeState](togglebutton_isthreestate.md) property to **true**.

> [!NOTE]
> ToggleButton has the same visual state for the indeterminate and unchecked states. Derived controls, like [CheckBox](../microsoft.ui.xaml.controls/checkbox.md), may define different visual states for each state.

### **ToggleButton** derived classes

ToggleButton is the parent class for several immediately derived controls that toggle and are selectable:

+ [AppBarToggleButton](../microsoft.ui.xaml.controls/appbartogglebutton.md)
+ [CheckBox](../microsoft.ui.xaml.controls/checkbox.md)
+ [RadioButton](../microsoft.ui.xaml.controls/radiobutton.md)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Toggle switches](/windows/apps/design/controls/toggles).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the ToggleButton in action](xamlcontrolsgallery:/item/ToggleButton).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

The following example shows how to create a three-state ToggleButton control.

[!code-xaml[1](../microsoft.ui.xaml.data/code/System.Windows.Controls.ToggleButtonThreeState/csharp/Page.xaml#Snippet1)]

## -see-also

[ButtonBase](buttonbase.md), [ToggleButton styles and templates](/windows/apps/design/style/xaml-styles), [AppBarToggleButton](../microsoft.ui.xaml.automation.peers/appbartogglebuttonautomationpeer.md), [CheckBox](../microsoft.ui.xaml.controls/checkbox.md), [RadioButton](../microsoft.ui.xaml.controls/radiobutton.md)
