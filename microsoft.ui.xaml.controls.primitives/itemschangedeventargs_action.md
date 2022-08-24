---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.ItemsChangedEventArgs.Action
-api-type: winrt property
---

<!-- Property syntax
public int Action { get; }
-->

# Microsoft.UI.Xaml.Controls.Primitives.ItemsChangedEventArgs.Action

## -description
Gets the action that occurred on the items collection.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The action that occurred.

## -remarks

The `int` values for this property correspond to the values of the [CollectionChange](/uwp/api/Windows.Foundation.Collections.CollectionChange) enum.

|Value |Action  |
|---------|---------|
| 0    | Reset - The collection is changed.       |
|1     | ItemInserted - An item is added to the collection.        |
|2     | ItemRemoved - An item is removed from the collection.        |
|3     | ItemChanged - An item is changed in the collection.        |

## -examples

## -see-also
