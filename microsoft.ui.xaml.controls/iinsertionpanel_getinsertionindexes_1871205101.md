---
-api-id: M:Microsoft.UI.Xaml.Controls.IInsertionPanel.GetInsertionIndexes(Windows.Foundation.Point,System.Int32@,System.Int32@)
-api-type: winrt method
---

<!-- Method syntax
public void GetInsertionIndexes(Windows.Foundation.Point position, System.Int32 first, System.Int32 second)
-->

# Microsoft.UI.Xaml.Controls.IInsertionPanel.GetInsertionIndexes

## -description
Returns the index values of the items that the specified point is between.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param position
The point for which to get insertion indexes.

### -param first
The index of the item before the specified point.

### -param second
The index of the item after the specified point.

## -remarks
Call this method when handling a [DragOver](../microsoft.ui.xaml/uielement_dragover.md) event to return the indices of the two items between which the [DragOver](../microsoft.ui.xaml/uielement_dragover.md) is happening and where a potential drop and insertion would happen.

## -examples

## -see-also
