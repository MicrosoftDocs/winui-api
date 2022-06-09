---
-api-id: E:Microsoft.UI.Xaml.Controls.ScrollViewer.ViewChanging
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.EventHandler ViewChanging<Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs>
-->

# Microsoft.UI.Xaml.Controls.ScrollViewer.ViewChanging

## -description
Occurs when manipulations such as scrolling and zooming cause the view to change.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ScrollViewer ViewChanging="eventhandler"/>
```


## -remarks
[ScrollViewerViewChangingEventArgs](scrollviewerviewchangingeventargs.md) includes the [IsInertial](scrollviewerviewchangingeventargs_isinertial.md) property, which reports whether the manipulation that is firing the event contains an inertial component.

Not every underlying manipulation will necessarily fire this event. The [ScrollViewer](scrollviewer.md) logic delays and consolidates intermediate events into a single occurrence in some cases.

## -examples

## -see-also
[ScrollViewerViewChangingEventArgs](scrollviewerviewchangingeventargs.md)
