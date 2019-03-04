---
-api-id: M:Microsoft.UI.Xaml.Controls.ElementAnimator.HasBoundsChangeAnimationCore(Windows.UI.Xaml.UIElement,Microsoft.UI.Xaml.Controls.AnimationContext,Windows.Foundation.Rect,Windows.Foundation.Rect)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
virtual protected bool ElementAnimator.HasBoundsChangeAnimationCore(UIElement element, AnimationContext context, Rect oldBounds, Rect newBounds)
-->

# Microsoft.UI.Xaml.Controls.ElementAnimator.HasBoundsChangeAnimationCore

## -description

When implemented in a derived class, determines whether a _bounds change_ animation is being provided by this animator.

## -parameters

### -param element

The element to animate.

### -param context

Information about the reason for the animation.

### -param oldBounds

The old bounds used to arrange the element.

### -param newBounds

The new bounds used to arrange the element.

## -returns

**true** if the animation is being provided by this animator; otherwise, **false**.

## -remarks

Override this method in a derived class to provide the behavior when [HasBoundsChangeAnimation](elementanimator_hasboundschangeanimation_12159397.md) is called.

The base implementation throws a [NotImplementedException](/dotnet/api/system.notimplementedexception) ([winrt::hresult_not_implemented](/uwp/cpp-ref-for-winrt/error-handling/hresult-not-implemented)).

## -see-also

## -examples

