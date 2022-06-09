---
-api-id: P:Microsoft.UI.Xaml.Application.HighContrastAdjustment
-api-type: winrt property
---

<!-- Property syntax.
public ApplicationHighContrastAdjustment HighContrastAdjustment { get;  set; }
-->

# Microsoft.UI.Xaml.Application.HighContrastAdjustment

## -description
Gets or sets a value that indicates whether the framework automatically adjusts visual properties when high contrast themes are enabled.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
A value of the enumeration that indicates whether the framework automatically adjusts visual properties when high contrast themes are enabled. The default is **Auto**.

## -remarks
The value of this property affects all [UIElement](uielement.md) instances where the UIElement's [HighContrastAdjustment](uielement_highcontrastadjustment.md) has not been explicitly set.  Setting it to **None** provides an easy way to disable the framework's automatic adjustments across all its windows and elements.

For more information about the behavior of this feature, see the remarks for the [UIElement.HighContrastAdjustment](uielement_highcontrastadjustment.md) property.

## -see-also

## -examples

