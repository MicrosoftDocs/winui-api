---
-api-id: P:Microsoft.UI.Xaml.Markup.IProvideValueTarget.TargetObject
-api-type: winrt property
---

# Microsoft.UI.Xaml.Markup.IProvideValueTarget.TargetObject

<!--
public object TargetObject { get; }
-->

## -description

Gets the target object being reported.

## -property-value

The target object being reported.

## -remarks

The value returned by TargetObject is the actual reference, not a type system identifier or other identifier. The value can also be null.

> [!IMPORTANT]
> When using the service, it is particularly important not to modify the object referenced by the TargetObject property, or other objects referenced by that object as properties that are not specifically the value-conversion case you are handling.

## -see-also

## -examples
