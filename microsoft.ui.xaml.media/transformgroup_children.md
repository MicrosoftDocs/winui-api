---
-api-id: P:Microsoft.UI.Xaml.Media.TransformGroup.Children
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.TransformCollection Children { get;  set; }
-->

# Microsoft.UI.Xaml.Media.TransformGroup.Children

## -description
Gets or sets the collection of child [Transform](transform.md) objects.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<TransformGroup>
  oneOrMoreTransforms
</TransformGroup>
```


## -xaml-values
<dl><dt>oneOrMoreTransforms</dt><dd>oneOrMoreTransformsOne or more object elements for classes that derive from Transform. Typically these are the classes RotateTransform, ScaleTransform, SkewTransform, TranslateTransform, MatrixTransform, or TransformGroup. Object elements defined here become members of the collection when code accesses the Children property at run time.</dd>
</dl>
## -property-value
The collection of child [Transform](transform.md) objects. The default is an empty collection.

## -remarks

## -examples

## -see-also
