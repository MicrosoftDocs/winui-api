---
-api-id: P:Microsoft.UI.Xaml.Media.MatrixTransform.Matrix
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Matrix Matrix { get;  set; }
-->

# Microsoft.UI.Xaml.Media.MatrixTransform.Matrix

## -description
Gets or sets the [Matrix](matrix.md) that defines this transformation.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<MatrixTransform>
  <MatrixTransform.Matrix>
    singleMatrix
  </MatrixTransform.Matrix>
</MatrixTransform>
```


## -xaml-values
<dl><dt>singleMatrix</dt><dd>singleMatrixExactly one Matrix object element.</dd>
</dl>
## -property-value
The [Matrix](matrix.md) structure that defines this transformation. The default is an identity [Matrix](matrix.md). An identity matrix has a value of 1 in coefficients [1,1], [2,2], and [3,3]; and a value of 0 in the rest of the coefficients.

## -remarks

## -examples

## -see-also
