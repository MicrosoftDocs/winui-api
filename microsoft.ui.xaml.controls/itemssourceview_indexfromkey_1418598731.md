---
-api-id: M:Microsoft.UI.Xaml.Controls.ItemsSourceView.IndexFromKey(System.String)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.ItemsSourceView.IndexFromKey(System.String)

<!--
public int IndexFromKey (string key);
-->

## -description

Retrieves the index of the item that has the specified unique identifier (key).

## -parameters

### -param key

The unique identifier (key) of the item to find the index of.

## -returns

The index of the item with the specified _key_.

## -remarks

Check that the [HasKeyIndexMapping](itemssourceview_haskeyindexmapping.md) property is **true** before calling this method. If the data source does not support unique IDs (key values), this method causes a NotImplementedException.

## -see-also

## -examples

