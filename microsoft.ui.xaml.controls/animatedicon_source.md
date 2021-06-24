---
-api-id: P:Microsoft.UI.Xaml.Controls.AnimatedIcon.Source
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.AnimatedIcon.Source

<!--
public Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2 Source { get; set; }
-->

## -description

Gets or sets the animated visual shown by the `AnimatedIcon` object.

## -property-value

The animated visual shown by the `AnimatedIcon`. The default is `null`.

## -remarks

The `Source` property does not support XAML [attribute syntax](/windows/uwp/xaml-platform/xaml-syntax-guide#setting-a-property-by-using-attribute-syntax) (`<AnimatedIcon Source="..."/>`); you have to set the `Source` by using [XAML property element syntax](/windows/uwp/xaml-platform/xaml-syntax-guide#setting-a-property-by-using-property-element-syntax). However, `Source` is defined as the control's [content property](/windows/uwp/xaml-platform/xaml-syntax-guide#xaml-content-properties), so you can omit the explicit `<AnimatedIcon.Source>` tags. These XAML declarations produce the same result.

```xaml
<!--  These XAML declarations produce the same result. -->

<muxc:AnimatedIcon>
    <muxc:AnimatedIcon.Source>
        <animatedvisuals:AnimatedBackVisualSource/>
    </muxc:AnimatedIcon.Source>
</muxc:AnimatedIcon>

<muxc:AnimatedIcon>
    <animatedvisuals:AnimatedBackVisualSource/>
</muxc:AnimatedIcon>
```

WinUI provides animated visuals for some common icons in the [Microsoft.UI.Xaml.Controls.AnimatedVisuals](/windows/winui/api/microsoft.ui.xaml.controls.animatedvisuals) namespace.

You can create custom animations to use as an animated icon in your app. Animations can be created with [Adobe AfterEffects](https://www.adobe.com/products/aftereffects.html), then you can use that output with the [Lottie-Windows](/windows/communitytoolkit/animations/lottie) library to generate a custom class that implements [IAnimatedVisualSource2](ianimatedvisualsource2.md). You can use this class as the [Source](animatedicon_source.md) for an animated icon. For more information, see [Use Lottie to create animated content for an AnimatedIcon](/windows/apps/design/controls/animated-icon#use-lottie-to-create-animated-content-for-an-animatedicon).

## -see-also

[Animated icon overview](/windows/apps/design/controls/animated-icon), [AnimatedIcon](animatedicon.md), [IAnimatedVisualSource.TryCreateAnimatedVisual](ianimatedvisualsource_trycreateanimatedvisual_646476001.md), [Microsoft.UI.Xaml.Controls.AnimatedVisuals](/windows/winui/api/microsoft.ui.xaml.controls.animatedvisuals)

## -examples

This example sets the `AnimatedIcon.Source` property to [AnimatedBackVisualSource](../microsoft.ui.xaml.controls.animatedvisuals/animatedbackvisualsource.md).

```xaml
<!-- 
xmlns:muxc="using:Microsoft.UI.Xaml.Controls"
xmlns:animatedvisuals="using:Microsoft.UI.Xaml.Controls.AnimatedVisuals"
-->

<muxc:AnimatedIcon>
    <animatedvisuals:AnimatedBackVisualSource/>
</muxc:AnimatedIcon>
```
