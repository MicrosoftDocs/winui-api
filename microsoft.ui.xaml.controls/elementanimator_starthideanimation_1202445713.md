---
-api-id: M:Microsoft.UI.Xaml.Controls.ElementAnimator.StartHideAnimation(Windows.UI.Xaml.UIElement,Microsoft.UI.Xaml.Controls.AnimationContext)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
virtual protected void ElementAnimator.StartHideAnimation(UIElement element, AnimationContext context)
-->

# Microsoft.UI.Xaml.Controls.ElementAnimator.StartHideAnimation

## -description

Starts the animation to play when an element is conceptually removed from the visual tree.

## -parameters

### -param element

The element to animate.

### -param context

Information about the change that is being animated.

## -remarks

Override this method in a derived class to start a hide animation.

The base implementation throws a [NotImplementedException](/dotnet/api/system.notimplementedexception) ([winrt::hresult_not_implemented](/uwp/cpp-ref-for-winrt/error-handling/hresult-not-implemented)).

## -see-also

## -examples

