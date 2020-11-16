---
-api-id: M:Microsoft.UI.Xaml.Controls.IAnimatedVisualSource.TryCreateAnimatedVisual(Windows.UI.Composition.Compositor,System.Object@)
-api-type: winrt method
---

<!-- Method syntax.
public IAnimatedVisual IAnimatedVisualSource.TryCreateAnimatedVisual(Compositor compositor, Object diagnostics)
-->

# Microsoft.UI.Xaml.Controls.IAnimatedVisualSource.TryCreateAnimatedVisual

## -description

Attempts to create an instance of an animated visual.

## -parameters

### -param compositor

The [Compositor](/uwp/api/windows.ui.composition.compositor) that will be used to create objects for the animated visual.

### -param diagnostics

An optional object containing diagnostics information about the result. The type and contents of the object depend on the implementation of [IAnimatedVisualSource](ianimatedvisualsource.md).

## -returns

An [IAnimatedVisual](ianimatedvisual.md), or **null**.

## -remarks

The _diagnostics_ argument contains optional diagnostics information about the animated visual. The runtime type of the object and the meaning of its information is determined by the [IAnimatedVisualSource](ianimatedvisualsource.md).

## -see-also

[IAnimatedVisualSource](ianimatedvisualsource.md)

## -examples

