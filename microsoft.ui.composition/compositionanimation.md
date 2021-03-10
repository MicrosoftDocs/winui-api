---
-api-id: T:Microsoft.UI.Composition.CompositionAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionAnimation : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.ICompositionAnimation, Windows.UI.Composition.ICompositionAnimation2, Windows.UI.Composition.ICompositionAnimationBase
-->

# Microsoft.UI.Composition.CompositionAnimation

## -description
Represents the base animation class.

## -remarks

This is the base class for [ExpressionAnimation](expressionanimation.md) and [KeyFrameAnimation](keyframeanimation.md).

Use the [CompostionObject.StartAnimation](compositionobject_startanimation_394405412.md) and [CompostionObject.StopAnimation](compositionobject_stopanimation_1075337060.md) methods to start and stop the animation.

Value parameters (as opposed to reference parameters which are set using [SetReferenceParameter](compositionanimation_setreferenceparameter_1113449737.md)) are copied and "embedded" into an expression at the time [CompositionObject.StartAnimation](compositionobject_startanimation_394405412.md) is called. Changing the value of the variable after [CompositionObject.StartAnimation](compositionobject_startanimation_394405412.md) is called will not affect the value of the [ExpressionAnimation](expressionanimation.md). See the remarks section of [ExpressionAnimation](expressionanimation.md) for additional information.

## -examples

## -see-also

[ExpressionAnimation](expressionanimation.md), [KeyFrameAnimation](keyframeanimation.md), [Composition Animations Overview](/en-us/windows/uwp/composition/composition-animation), [CompositionObject](compositionobject.md), [IClosable](/uwp/api/windows.foundation.iclosable)
