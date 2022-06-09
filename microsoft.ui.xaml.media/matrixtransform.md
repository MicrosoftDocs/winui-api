---
-api-id: T:Microsoft.UI.Xaml.Media.MatrixTransform
-api-type: winrt class
---

<!-- Class syntax.
public class MatrixTransform : Windows.UI.Xaml.Media.Transform, Windows.UI.Xaml.Media.IMatrixTransform
-->

# Microsoft.UI.Xaml.Media.MatrixTransform

## -description
Creates an arbitrary affine matrix transformation that is used to manipulate objects or coordinate systems in a two-dimensional plane.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<MatrixTransform .../>
```

```xaml
<object property="m11, m12, m21, m22, offsetX, offsetY"/>
- or -
<object property="Identity"/>
```


## -remarks

## -examples
This example transforms the position and skew of a rectangle using a MatrixTransform.



[!code-xaml[matrixtransform](../microsoft.ui.xaml/code/transforms/csharp/Matrix_Transform.xaml#Snippetmatrixtransform)]

## -see-also
[Transform](transform.md)
