---
-api-id: T:Microsoft.UI.Xaml.Media.PlaneProjection
-api-type: winrt class
---

<!-- Class syntax.
public class PlaneProjection : Windows.UI.Xaml.Media.Projection, Windows.UI.Xaml.Media.IPlaneProjection
-->

# Microsoft.UI.Xaml.Media.PlaneProjection

## -description
Represents a perspective transform (a 3-D-like effect) on an object.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<PlaneProjection .../>
```


## -remarks

## -examples
To apply a perspective transform to a [UIElement](../microsoft.ui.xaml/uielement.md), set the [UIElement](../microsoft.ui.xaml/uielement.md) object's [Projection](../microsoft.ui.xaml/uielement_projection.md) property to a PlaneProjection. The PlaneProjection defines how the transform is rendered in space. This example shows a simple case.



[!code-xaml[BasicPerspectiveTransforms](../microsoft.ui.xaml/code/BasicPerspectiveTransforms/csharp/MainPage.xaml#SnippetBasicPerspectiveTransforms)]

## -see-also
[3-D effects for ](/previous-versions/windows/apps/hh700359(v=win.10)), [Projection](projection.md)
