---
-api-id: T:Microsoft.UI.Xaml.Data.INotifyDataErrorInfo
-api-type: winrt interface
---

# Microsoft.UI.Xaml.Data.INotifyDataErrorInfo

<!--
public interface INotifyDataErrorInfo
-->

## -description

Defines members that data entity classes can implement to provide custom synchronous and asynchronous validation support.

## -remarks

This interface enables data entity classes to implement custom validation rules and expose validation results asynchronously. This interface also supports custom error objects, multiple errors per property, cross-property errors, and entity-level errors. Cross-property errors are errors that affect multiple properties. You can associate these errors with one or all of the affected properties, or you can treat them as entity-level errors. Entity-level errors are errors that either affect multiple properties or affect the entire entity without affecting a particular property.

## -see-also

## -examples
