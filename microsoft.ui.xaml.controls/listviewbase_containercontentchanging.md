---
-api-id: E:Microsoft.UI.Xaml.Controls.ListViewBase.ContainerContentChanging
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ContainerContentChanging<Windows.UI.Xaml.Controls.ListViewBase,  Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs>
-->

# Microsoft.UI.Xaml.Controls.ListViewBase.ContainerContentChanging

## -description
Occurs when the data item associated with a UI container changes.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<listViewBase ContainerContentChanging="eventhandler" />
```


## -remarks
This event is raised only if the list or grid's [ItemsPanel](itemscontrol_itemspanel.md) is an [ItemsStackPanel](itemsstackpanel.md) or [ItemsWrapGrid](itemswrapgrid.md). If you replace the [ItemsPanel](itemscontrol_itemspanel.md) with another panel, the event is not raised.

For info and examples, see the [Update ListView and GridView items incrementally](/windows/uwp/debug-test-perf/optimize-gridview-and-listview) section of [Optimize ListView and GridView](/windows/uwp/debug-test-perf/optimize-gridview-and-listview).

For more examples, download the [XAML GridView grouping and SemanticZoom sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20GridView%20grouping%20and%20SemanticZoom%20sample).

## -examples

## -see-also
[Optimize ListView and GridView](/windows/uwp/debug-test-perf/optimize-gridview-and-listview), [XAML GridView grouping and SemanticZoom sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20GridView%20grouping%20and%20SemanticZoom%20sample)
