---
-api-id: P:Microsoft.UI.Xaml.Controls.Border.BackgroundTransition
-api-type: winrt property
---

<!-- Property syntax.
public BrushTransition BackgroundTransition { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Border.BackgroundTransition

## -description

Gets or sets an instance of BrushTransition to automatically animate changes to the Background property.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

An instance of [BrushTransition](../microsoft.ui.xaml/brushtransition.md) to automatically animate changes to the [Background](border_background.md); otherwise, **null**. The default is **null**.

## -remarks

Use this property to animate any change to the [Background](border_background.md) property. When a new value is set from code or through data binding, the change is animated from the old value to the new value, rather than happening instantaneously.  

Even though the transition animation takes time, the change to the actual property value is instantaneous. For example, if you change a property from code and then read it back, you’ll see the new value, even though the visual effect of the property change is somewhere between the new and the old.

If a property value changes a second time while the first change is still animating, the animation will use the currently animated value as the "starting" value for the next animation, and then animate to the new "final" value. The duration will be reset.  

## -see-also

[BrushTransition](../microsoft.ui.xaml/brushtransition.md), [Background](border_background.md)

## -examples

This example shows how to apply a background transition to a Border. Each time `BorderBackground` is updated, the background will animate from the old brush to the new brush.

```xaml
<Border Background="{x:Bind BorderBackground}">
    <Border.BackgroundTransition>
        <BrushTransition />
    </Border.BackgroundTransition>
</Border>
```
