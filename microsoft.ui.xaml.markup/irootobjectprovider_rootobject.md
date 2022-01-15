---
-api-id: P:Microsoft.UI.Xaml.Markup.IRootObjectProvider.RootObject
-api-type: winrt property
---

# Microsoft.UI.Xaml.Markup.IRootObjectProvider.RootObject

<!--
public object RootObject { get; }
-->

## -description

Gets the root object from markup or from an object graph.

## -property-value

The root object.

## -remarks

The root object in a XAML markup scenario might be useful for markup extension scenarios because of attributes that might by convention be set at the root level of XAML markup. Specific root object capabilities might be specified by frameworks. For example, certain attributes might only be valid at the root level, or a framework might support inheritance of global properties from the root.

## -see-also

## -examples
