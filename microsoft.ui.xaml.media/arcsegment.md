---
-api-id: T:Microsoft.UI.Xaml.Media.ArcSegment
-api-type: winrt class
---

<!-- Class syntax.
public class ArcSegment : Windows.UI.Xaml.Media.PathSegment, Windows.UI.Xaml.Media.IArcSegment
-->

# Microsoft.UI.Xaml.Media.ArcSegment

## -description
Represents an elliptical arc between two points.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ArcSegment .../>
```


## -remarks
At a minimum each ArcSegment should have its [RotationAngle](arcsegment_rotationangle.md) and [Size](arcsegment_size.md) properties set, because these don't have useful defaults.

This class is relevant for setting the vector data for either a [Path](../microsoft.ui.xaml.shapes/path.md) or a [PathIcon](../microsoft.ui.xaml.controls/pathicon.md).

Rather than creating an instance or an object element, you can also define an ArcSegment as part of a vector within the string for a [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax).

## -examples

## -see-also
[PathSegment](pathsegment.md), [Path](../microsoft.ui.xaml.shapes/path.md), [PathGeometry](pathgeometry.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes), [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax)
