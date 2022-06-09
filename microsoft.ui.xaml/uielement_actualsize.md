---
-api-id: P:Microsoft.UI.Xaml.UIElement.ActualSize
-api-type: winrt property
---

<!-- Property syntax.
public Vector2 ActualSize { get; }
-->

# Microsoft.UI.Xaml.UIElement.ActualSize

## -description

Gets the size that this UIElement computed during the arrange pass of the layout process.  

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The size that this UIElement computed during the arrange pass of the layout process.

## -remarks 

The ActualSize property is equivalent to the [ActualWidth](frameworkelement_actualwidth.md) and [ActualHeight](frameworkelement_actualheight.md) properties, but represented as a Vector2. ActualSize can be used as an input property to an [ExpressionAnimation](../microsoft.ui.composition/expressionanimation.md).

When the ActualSize changes, the [FrameworkElement.SizeChanged](frameworkelement_sizechanged.md) event is raised. The value of [SizeChangedEventArgs.NewSize](sizechangedeventargs_newsize.md) will be the new value of the ActualSize.

## -see-also

## -examples

