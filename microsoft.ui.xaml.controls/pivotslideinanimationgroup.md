---
-api-id: T:Microsoft.UI.Xaml.Controls.PivotSlideInAnimationGroup
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.PivotSlideInAnimationGroup : int
-->

# PivotSlideInAnimationGroup

## -description
Defines constants that specify the different slide-in animation groups that [Pivot](pivot.md) elements can belong to.

> [!Important]
> The **Pivot** control is no longer recommended and could be removed in future releases of the Windows UI Library (WinUI). Note that information and images in this topic might be out of date.
>
> Please use the [NavigationView](navigationview.md) ([NavigationViewPaneDisplayMode](navigationviewpanedisplaymode.md) of Top) instead.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -enum-fields
### -field Default:0
The element belongs to the default animation group. It slides in after the [Pivot](pivot.md) header.

### -field GroupOne:1
The element belongs to the first animation group. It slides in after elements in the default group.

### -field GroupTwo:2
The element belongs to the second animation group. It slides in after elements in the first group.

### -field GroupThree:3
The element belongs to the third animation group. It slides in after elements in the second group.


## -remarks
These values are used by the [Pivot.SlideInAnimationGroup](/windows/winui/api/microsoft.ui.xaml.controls.pivot#xaml-attached-properties) attached property.

## -examples

## -see-also
[Pivot.SlideInAnimationGroup](/windows/winui/api/microsoft.ui.xaml.controls.pivot#xaml-attached-properties)
