---
-api-id: M:Microsoft.UI.Xaml.Controls.ElementAnimator.HasShowAnimationCore(Windows.UI.Xaml.UIElement,Microsoft.UI.Xaml.Controls.AnimationContext)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
virtual protected bool ElementAnimator.HasShowAnimationCore(UIElement element, AnimationContext context)
-->

# Microsoft.UI.Xaml.Controls.ElementAnimator.HasShowAnimationCore

## -description

When implemented in a derived class, determines whether a _show_ animation is being provided by this animator.

## -parameters

### -param element

The element to animate.

### -param context

Information about the reason for the animation.

## -returns

**true** if the animation is being provided by this animator, **false**.

## -remarks

Override this method in a derived class to provide the behavior when [HasShowAnimation](elementanimator_hasshowanimation_908333191.md) is called.

The base implementation throws a [NotImplementedException](/dotnet/api/system.notimplementedexception) ([winrt::hresult_not_implemented](/uwp/cpp-ref-for-winrt/error-handling/hresult-not-implemented)).

## -see-also

## -examples

