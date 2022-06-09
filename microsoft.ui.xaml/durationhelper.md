---
-api-id: T:Microsoft.UI.Xaml.DurationHelper
-api-type: winrt class
---

<!-- Class syntax.
public class DurationHelper : Windows.UI.Xaml.IDurationHelper
-->

# Microsoft.UI.Xaml.DurationHelper

## -description

Provides basic utility methods for processing [Duration](duration.md) values. C**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

# and Microsoft Visual Basic code should use methods of [Duration](duration.md) instead.

## -remarks

[Duration](duration.md) is a Windows Runtime structure that represents a unit of time for an animation behavior. For example, [Timeline.Duration](../microsoft.ui.xaml.media.animation/timeline_duration.md) uses a [Duration](duration.md) value.

DurationHelper is one of several **Helper** classes that are intended to provide utility methods for Windows Runtime structure values. C# and Microsoft Visual Basic code can use members of [Duration](duration.md) instead, because utility members are available directly on the structure due to .NET Framework runtime support. C++ code can only access the **Timespan** data value on [Duration](duration.md). For C++ developers, approximately the same utility features that a Microsoft Visual Basic developer could use directly on [Duration](duration.md) are available in a static form on the DurationHelper class.

## -examples

## -see-also

[Duration](duration.md), [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations)
