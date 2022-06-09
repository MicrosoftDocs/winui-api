---
-api-id: E:Microsoft.UI.Xaml.Controls.TreeView.DragItemsStarting
-api-type: winrt event
---
<!-- Event syntax.
public event TypedEventHandler DragItemsStarting<TreeView, TreeViewDragItemsStartingEventArgs>
-->

# Microsoft.UI.Xaml.Controls.TreeView.DragItemsStarting


## -description

Occurs when a drag operation that involves one of the items in the view is initiated.


**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

To receive this event, set the [CanDragItems](treeview_candragitems.md) property to **true**.

This event occurs when you start a drag-and-drop operation, including when you perform a reorder operation by drag-and-drop. When you perform custom actions as a result of a drag-and-drop operation, you typically listen to this event and provide more data using the [TreeViewDragItemsStartingEventArgs.Data](treeviewdragitemsstartingeventargs_data.md) property.

You can inspect the items being dragged by checking the [TreeViewDragItemsStartingEventArgs.Items](treeviewdragitemsstartingeventargs_items.md) property.

You can cancel the drag operation by setting the [TreeViewDragItemsStartingEventArgs.Cancel](treeviewdragitemsstartingeventargs_cancel.md) property to **true**.


## -see-also
[TreeViewDragItemsStartingEventArgs](treeviewdragitemsstartingeventargs.md)


## -examples


## -xaml-syntax

```xaml
<TreeView DragItemsStarting="eventhandler"/>
```


