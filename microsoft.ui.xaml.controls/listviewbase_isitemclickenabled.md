---
-api-id: P:Microsoft.UI.Xaml.Controls.ListViewBase.IsItemClickEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsItemClickEnabled { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ListViewBase.IsItemClickEnabled

## -description
Gets or sets a value that indicates whether items in the view fire an [ItemClick](listviewbase_itemclick.md) event in response to interaction.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<listViewBase IsItemClickEnabled="bool" />
```


## -property-value
**true** if interaction fires an [ItemClick](listviewbase_itemclick.md) event; otherwise, **false**. The default is **false**.

## -remarks
By default, a user can select items in the view by tapping or clicking on them. You can change this behavior to make the user interaction fire a click event instead of triggering item selection.

If you set the IsItemClickEnabled property to **true**, you must set the [SelectionMode](listviewbase_selectionmode.md) property to [ListViewSelectionMode.None](listviewselectionmode.md). Handle the [ItemClick](listviewbase_itemclick.md) event to respond to the user interaction.

## -examples

## -see-also
[SelectionMode](listviewbase_selectionmode.md), [ItemClick](listviewbase_itemclick.md)
