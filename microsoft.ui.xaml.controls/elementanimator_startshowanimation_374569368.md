---
-api-id: M:Microsoft.UI.Xaml.Controls.ElementAnimator.StartShowAnimation(Windows.UI.Xaml.UIElement,Microsoft.UI.Xaml.Controls.AnimationContext)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
virtual protected void ElementAnimator.StartShowAnimation(UIElement element, AnimationContext context)
-->

# Microsoft.UI.Xaml.Controls.ElementAnimator.StartShowAnimation

## -description

Starts the animation to play when an element is conceptually added to the visual tree.

## -parameters

### -param element

The element to animate.

### -param context

Information about the change that is being animated.

## -remarks

Override this method in a derived class to start a show animation.

The base implementation throws a [NotImplementedException](/dotnet/api/system.notimplementedexception) ([winrt::hresult_not_implemented](/uwp/cpp-ref-for-winrt/error-handling/hresult-not-implemented)).

## -see-also

## -examples

