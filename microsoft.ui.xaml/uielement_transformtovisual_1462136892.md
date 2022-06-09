---
-api-id: M:Microsoft.UI.Xaml.UIElement.TransformToVisual(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Media.GeneralTransform TransformToVisual(Windows.UI.Xaml.UIElement visual)
-->

# Microsoft.UI.Xaml.UIElement.TransformToVisual

## -description
Returns a transform object that can be used to transform coordinates from the [UIElement](uielement.md) to the specified object.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param visual
The object to compare to the current object for purposes of obtaining the transform.
If this parameter is null, then the root of the XAML tree is used. 

## -returns
The transform information as an object. Call methods on this object to get a practical transform.

## -remarks
Call TransformToVisual in order to get a coordinate offset between two elements in a UI. The first element being considered is the [UIElement](uielement.md) where you call TransformToVisual, the second element is the [UIElement](uielement.md) you pass as the *visual* parameter. For example, you can use the transform to determine how the bounds of an element are positioned in a coordinate system that is relative to a layout parent element, rather than the app's window.

TransformToVisual gives coordinate results after all considerations that affect rendering and positioning such as [RenderTransform](uielement_rendertransform.md) have been applied. This is useful if you're processing point values that were obtained during an animation of [RenderTransform](uielement_rendertransform.md) or other position changes.

The most common scenario for TransformToVisual is if you want to use a local coordinate system relative to the [UIElement](uielement.md) you call it on, and you aren't handling a real-time input event that has event data methods for converting a [Point](/uwp/api/windows.foundation.point) value into the object's frame of reference. After you call TransformToVisual, you can then call [TransformPoint](../microsoft.ui.xaml.media/generaltransform_transformpoint_1768161830.md) on the returned [GeneralTransform](../microsoft.ui.xaml.media/generaltransform.md).

> [!NOTE]
> The [GeneralTransform](../microsoft.ui.xaml.media/generaltransform.md) object returned by this method can be cast to a derived type, [Transform](../microsoft.ui.xaml.media/transform.md), but all the methods you need are defined by [GeneralTransform](../microsoft.ui.xaml.media/generaltransform.md). You can't cast to [TranslateTransform](../microsoft.ui.xaml.media/translatetransform.md) even though you might expect that the transform result would be a translation.

## -examples

This example shows a scenario for calling TransformToVisual in order to interpret the coordinates from a [PointerPoint](../microsoft.ui.input/pointerpoint.md) in the coordinate reference frame of an element that's not the event sender. Here, the `queryPointer` method first accesses coordinates that do relate to the sender but then later uses TransformToVisual to convert point coordinates into the reference frame for the `page` layout container that's actually several layers of containment higher in the XAML tree. To see more context for this code (including seeing how `queryPointer` displays results in UI and when it's called), see the complete code example that is shown in the topic [Handle pointer input](/windows/apps/design/input/handle-pointer-input).

:::code language="xaml" source="./microsoft.ui.input.inking/code/PointerInput/csharp/MainPage.xaml" id="SnippetUI":::

:::code language="csharp" source="./microsoft.ui.input.inking/code/PointerInput/csharp/MainPage.xaml.cs" id="SnippetQueryPointer":::

## -see-also

[GeneralTransform](../microsoft.ui.xaml.media/generaltransform.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml), [XAML two-dimensional transforms sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20two-dimensional%20transforms%20sample)
