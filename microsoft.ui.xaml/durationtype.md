---
-api-id: T:Microsoft.UI.Xaml.DurationType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.DurationType : int
-->

# DurationType

## -description
Declares whether a [Duration](duration.md) has a special value of [Automatic](durationhelper_automatic.md) or [Forever](durationhelper_forever.md), or has valid information in its **TimeSpan** component.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -enum-fields
### -field Automatic:0
Has the [Automatic](durationhelper_automatic.md) special value.

### -field TimeSpan:1
Has valid information in the **TimeSpan** component.

### -field Forever:2
Has the [Forever](durationhelper_forever.md) special value.


## -remarks
This value is used by the **Duration.Type** field, when you use C++ code and access the field data for a [Duration](duration.md).

For a [Duration](duration.md) the [Automatic](durationhelper_automatic.md) and [Forever](durationhelper_forever.md) values have different meaning depending on whether the [Duration](duration.md) is being used for the [Duration](../microsoft.ui.xaml.media.animation/timeline_duration.md) property on a [Storyboard](visualstate_storyboard.md) rather than on an individual storyboarded animation. For more info, see [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations).

For C# and Microsoft Visual Basic there is no **Type** property but you can use [HasTimeSpan](duration_hastimespan.md) to get similar information.

## -examples

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Duration](duration.md)
