---
-api-id: E:Microsoft.UI.Xaml.Controls.ItemsRepeater.ElementIndexChanged
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.ItemsRepeater.ElementIndexChanged

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.ItemsRepeater,Microsoft.UI.Xaml.Controls.ItemsRepeaterElementIndexChangedEventArgs> ElementIndexChanged;
-->

## -description

Occurs for each realized UIElement when the index for the item it represents has changed.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks

When you use ItemsRepeater to build a more complex control that supports specific interactions on the child elements (such as _selection_ or _click_), it is useful to be able to keep an up-to-date identifier for the backing data item.

This event is raised for each realized UIElement where the index for the item it represents has changed. For example, when another item is added or removed in the data source, the index for items that come after in the ordering will be impacted.  

## -see-also

## -examples

