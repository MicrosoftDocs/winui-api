---
-api-id: P:Microsoft.UI.Xaml.Media.ArcSegment.Size
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Size Size { get;  set; }
-->

# Microsoft.UI.Xaml.Media.ArcSegment.Size

## -description
Gets or sets the x-radius and y-radius of the arc as a [Size](/uwp/api/windows.foundation.size) structure.

## -xaml-syntax
```xaml
<ArcSegment Size="width,height"/>
```


## -xaml-values
<dl><dt>width,height</dt><dd>width,heightA double value for a width, a delimiter, and a double value for a height. The delimiter can be either a space or comma. An attribute value for a Size value uses a type converter to process the string.</dd>
</dl>
## -property-value
A [Size](/uwp/api/windows.foundation.size) structure that describes the x-radius and y-radius of the elliptical arc. The [Size](/uwp/api/windows.foundation.size) structure's **Width** value specifies the arc's x-radius; its **Height** value specifies the arc's y-radius. The default is a [Size](/uwp/api/windows.foundation.size) with value 0,0.

## -remarks

## -examples

## -see-also
[Draw shapes](/windows/uwp/graphics/drawing-shapes)
