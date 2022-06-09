---
-api-id: T:Microsoft.UI.Xaml.Controls.StyleSelector
-api-type: winrt class
---

<!-- Class syntax.
public class StyleSelector : Windows.UI.Xaml.Controls.IStyleSelector, Windows.UI.Xaml.Controls.IStyleSelectorOverrides
-->

# Microsoft.UI.Xaml.Controls.StyleSelector

## -description
Enables custom item style selection logic as a function of the content data and its specific item container.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
See Remarks
```


## -remarks
The base StyleSelector class is not used as an object element in XAML. However, it is a common scenario to derive a custom StyleSelector, map a xmlns prefix for the custom class and its namespace/assembly, and then refer to an instance of the custom class as defined in a [Resources](../microsoft.ui.xaml/frameworkelement_resources.md) block in XAML. This makes it possible to refer to the custom template selector class by **x:Key**, and use that reference to set the value of properties such as [ItemContainerStyleSelector](itemscontrol_itemcontainerstyleselector.md) in XAML templates and particular visual states.

## -examples

## -see-also
[ItemContainerStyleSelector](itemscontrol_itemcontainerstyleselector.md)
