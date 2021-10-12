---
-api-id: M:Microsoft.UI.Xaml.Data.INotifyDataErrorInfo.GetErrors(System.String)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Data.INotifyDataErrorInfo.GetErrors(System.String)

<!--
public System.Collections.Generic.IEnumerable<object> GetErrors (string propertyName);
-->

## -description

Gets the validation errors for a specified property or for the entire entity.

## -parameters

### -param propertyName

The name of the property to retrieve validation errors for. Null or Empty retrieves entity-level errors.

## -returns

The validation errors for the property or entity.

## -remarks

This method returns an [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1) that can change as asynchronous validation rules finish processing. This enables the binding engine to automatically update the user interface validation feedback when errors are added, removed, or modified.

The return value can change to a different IEnumerable, or it can reuse a previously returned IEnumerable and change its contents. Any changes to the return value should raise the [ErrorsChanged](inotifydataerrorinfo_errorschanged.md) event, even if the return value implements [INotifyCollectionChanged](../microsoft.ui.xaml.interop/inotifycollectionchanged.md).

## -see-also

## -examples
