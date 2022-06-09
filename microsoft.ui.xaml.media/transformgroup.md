---
-api-id: T:Microsoft.UI.Xaml.Media.TransformGroup
-api-type: winrt class
---

<!-- Class syntax.
public class TransformGroup : Windows.UI.Xaml.Media.Transform, Windows.UI.Xaml.Media.ITransformGroup
-->

# Microsoft.UI.Xaml.Media.TransformGroup

## -description
Represents a composite [Transform](transform.md) composed of other [Transform](transform.md) objects.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<TransformGroup>
  oneOrMoreTransforms
</TransformGroup>
```


## -remarks

## -examples
This example shows the markup for using a TransformGroup to fill the [RenderTransform](../microsoft.ui.xaml/uielement_rendertransform.md) property.



[!code-xaml[TransformGroup](../microsoft.ui.xaml/code/transforms/csharp/TransformGroup.xaml#SnippetTransformGroup)]

## -see-also
[Transform](transform.md)
