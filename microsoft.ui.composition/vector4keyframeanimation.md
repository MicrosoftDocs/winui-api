---
-api-id: T:Microsoft.UI.Composition.Vector4KeyFrameAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class Vector4KeyFrameAnimation : Windows.UI.Composition.KeyFrameAnimation, Windows.UI.Composition.IVector4KeyFrameAnimation
-->

# Microsoft.UI.Composition.Vector4KeyFrameAnimation

## -description
A time-based animation that targets any Vector4-based property with one or more keyframes.

## -remarks

Use the [CompostionObject.StartAnimation](compositionobject_startanimation_394405412.md) and [CompostionObject.StopAnimation](compositionobject_stopanimation_1075337060.md) methods to start and stop the animation.

An animation is associated with an object's property by calling [CompostionObject.StartAnimation](compositionobject_startanimation_394405412.md) and specifying the property name and the animation. See the remarks section of [CompostionObject.StartAnimation](compositionobject_startanimation_394405412.md) for a list of animatable properties.

## -examples

## -see-also
[Composition Animations Overview](/en-us/windows/uwp/composition/composition-animation), [KeyFrameAnimation](keyframeanimation.md), [IClosable](/uwp/api/windows.foundation.iclosable)
