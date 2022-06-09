---
-api-id: E:Microsoft.UI.Xaml.Controls.SplitView.PaneClosing
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PaneClosing<Windows.UI.Xaml.Controls.SplitView,  Windows.UI.Xaml.Controls.SplitViewPaneClosingEventArgs>
-->

# Microsoft.UI.Xaml.Controls.SplitView.PaneClosing

## -description
Occurs when the [SplitView](splitview.md) pane is closing.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml

      <SplitView PaneClosing="eventhandler"/>
    
```


## -remarks
Set the [SplitViewPaneClosingEventArgs.Cancel](splitviewpaneclosingeventargs_cancel.md) property to **true** in a handler for this event in order to cancel a [SplitView](splitview.md) pane closing action.

## -examples

## -see-also
[PaneClosed](splitview_paneclosed.md)
