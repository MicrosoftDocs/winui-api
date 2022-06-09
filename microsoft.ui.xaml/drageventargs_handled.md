---
-api-id: P:Microsoft.UI.Xaml.DragEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax
public bool Handled { get;  set; }
-->

# Microsoft.UI.Xaml.DragEventArgs.Handled

## -description
Gets or sets a value that indicates the present state of the event handling for a routed event as it travels the route.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
**true** if the event is marked handled; otherwise, **false**. The default value is **false**.

## -remarks
The events that use [DragEventArgs](drageventargs.md) for event data are routed events. Setting the value of the Handled property to **true** from an event handler can influence how a routed event behaves: it prevents handlers further along the route from being invoked. However, a handler that was attached by calling [AddHandler](uielement_addhandler_1350394113.md) with *handledEventsToo* is still invoked. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

## -examples

## -see-also
[Drag-and-drop overview](/windows/apps/design/input/drag-and-drop), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview)
