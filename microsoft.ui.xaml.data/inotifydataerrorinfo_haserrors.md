---
-api-id: P:Microsoft.UI.Xaml.Data.INotifyDataErrorInfo.HasErrors
-api-type: winrt property
---

# Microsoft.UI.Xaml.Data.INotifyDataErrorInfo.HasErrors

<!--
public bool HasErrors { get; }
-->

## -description

Gets a value that indicates whether the entity has validation errors.

## -property-value

True if the entity currently has validation errors. Otherwise, false.

## -remarks

This property returns false if there are no known entity-level or property-level validation errors for the entity at the time it is accessed. However, some validation rules may still be running asynchronously as described for the [GetErrors](inotifydataerrorinfo_geterrors_371395264.md) method.

## -see-also

## -examples
