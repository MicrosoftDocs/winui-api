---
-api-id: M:Microsoft.UI.Xaml.DependencyObject.GetValue(Microsoft.UI.Xaml.DependencyProperty)
-api-type: winrt method
---

<!-- Method syntax
public object GetValue(Windows.UI.Xaml.DependencyProperty dp)
-->

# Microsoft.UI.Xaml.DependencyObject.GetValue

## -description
Returns the current effective value of a dependency property from a [DependencyObject](dependencyobject.md).

## -parameters
### -param dp
The [DependencyProperty](dependencyproperty.md) identifier of the property for which to retrieve the value.

## -returns
Returns the current effective value.

## -remarks
GetValue obtains the current effective value of a dependency property. The current effective value is determined by using rules of [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

GetValue is the API you want in most cases if you are using the property system API for obtaining property values. But sometimes you might want to examine other values to see how the dependency property precedence is acting for a given property. If so, you can use one of these API:


+ [GetAnimationBaseValue](dependencyobject_getanimationbasevalue_1955567622.md) to get values that might currently be animated but you want to know the value before the animation ran. Note that animations with [HoldEnd](../microsoft.ui.xaml.media.animation/fillbehavior.md) behavior might not have this same value. For more info on the [HoldEnd](../microsoft.ui.xaml.media.animation/fillbehavior.md) concept, see [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations).
+ [ReadLocalValue](dependencyobject_readlocalvalue_1526948202.md) to get the local value, which does not have styles or templates or animations applied. Bindings do count as local values, but depending on when you call [ReadLocalValue](dependencyobject_readlocalvalue_1526948202.md), the acting binding context might not be available yet, so you won't get the same value as would be applied at run time.
For more info on dependency property precedence and other property system utility API, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

## -examples

## -see-also
[SetValue](dependencyobject_setvalue_1212521140.md), [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview)
