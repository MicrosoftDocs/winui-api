---
-api-id: M:Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.GetOrCreateElementAt(System.Int32)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.GetOrCreateElementAt(System.Int32)

<!--
public Windows.UI.Xaml.UIElement GetOrCreateElementAt (int index);
-->

## -description

Retrieves a UIElement that represents the data item in the source found at the specified index. By default, if an element already exists, it is returned; otherwise, a new element is created.

## -parameters

### -param index

The index of the data item to retrieve a UIElement for.

## -returns

A UIElement that represents the data item.

## -remarks

This method calls [GetOrCreateElementAtCore(System.Int32,Microsoft.UI.Xaml.Controls.ElementRealizationOptions)](virtualizinglayoutcontext_getorcreateelementatcore_440237553.md) with options set to **None**.

GetElementAtCore must be implemented in a derived class.

## -see-also

## -examples

