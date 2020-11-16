---
-api-id: M:Microsoft.UI.Xaml.Hosting.ElementCompositionPreview.SetImplicitHideAnimation(Microsoft.UI.Xaml.UIElement,Microsoft.UI.Composition.ICompositionAnimationBase)
-api-type: winrt method
---

<!-- Method syntax.
public void ElementCompositionPreview.SetImplicitHideAnimation(UIElement element, ICompositionAnimationBase animation)
-->

# Microsoft.UI.Xaml.Hosting.ElementCompositionPreview.SetImplicitHideAnimation

## -description

Associates the specified hide animation with a UIElement.

## -parameters

### -param element

The UIElement to associate the animation with.

### -param animation

The animation to play when the UIElement is hidden. A **Null** value prevents hide animations from playing for this element until the method is called again with an animation value.

## -remarks

When an element is removed from the scene or its **Visibility** property becomes **Visibility.Collapsed**, the element and all of its descendents in the UI tree will play their hide animations.

## -see-also

## -examples

