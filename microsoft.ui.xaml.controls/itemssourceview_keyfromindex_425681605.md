---
-api-id: M:Microsoft.UI.Xaml.Controls.ItemsSourceView.KeyFromIndex(System.Int32)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.ItemsSourceView.KeyFromIndex(System.Int32)

<!--
public string KeyFromIndex (int index);
-->

## -description

Retrieves the unique identifier (key) for the item at the specified index.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param index

The index of the item to get the key for.

## -returns

The unique identifier (key) for the item at the specified _index_.

## -remarks

Check that the [HasKeyIndexMapping](itemssourceview_haskeyindexmapping.md) property is **true** before calling this method. If the data source does not support unique IDs (key values), this method causes a NotImplementedException.

Use the [Count](itemssourceview_count.md) property to make sure you are passing a valid _index_.

## -see-also

## -examples

