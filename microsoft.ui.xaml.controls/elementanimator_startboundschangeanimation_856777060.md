---
-api-id: M:Microsoft.UI.Xaml.Controls.ElementAnimator.StartBoundsChangeAnimation(Windows.UI.Xaml.UIElement,Microsoft.UI.Xaml.Controls.AnimationContext,Windows.Foundation.Rect,Windows.Foundation.Rect)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
virtual protected void ElementAnimator.StartBoundsChangeAnimation(UIElement element, AnimationContext context, Rect oldBounds, Rect newBounds)
-->

# Microsoft.UI.Xaml.Controls.ElementAnimator.StartBoundsChangeAnimation

## -description

Starts the animation to play when the bounds used to arrange an element change.

## -parameters

### -param element

The element to animate.

### -param context

Information about the change that is being animated.

### -param oldBounds

The old bounds used to arrange the element.

### -param newBounds

The new bounds used to arrange the element.

## -remarks

Override this method in a derived class to start a bounds changed animation.

The base implementation throws a [NotImplementedException](/dotnet/api/system.notimplementedexception) ([winrt::hresult_not_implemented](/uwp/cpp-ref-for-winrt/error-handling/hresult-not-implemented)).

## -see-also

## -examples

