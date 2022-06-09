---
-api-id: T:Microsoft.UI.Xaml.DragEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void DragEventHandler(System.Object sender, Windows.UI.Xaml.DragEventArgs e)
-->
# Microsoft.UI.Xaml.DragEventHandler

## -description
Represents the method that will handle the [DragEnter](uielement_dragenter.md), [DragLeave](uielement_dragleave.md), [DragOver](uielement_dragover.md), and [Drop](uielement_drop.md) events of a [UIElement](uielement.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param sender
The object where the event handler is attached.

### -param e
The event data.


## -remarks
DragEventHandler is the delegate you implement to handle these events:
+ [UIElement.DragEnter](uielement_drop.md)
+ [UIElement.DragLeave](uielement_dragleave.md)
+ [UIElement.DragOver](uielement_dragover.md)
+ [UIElement.Drop](uielement_drop.md)
These events are routed events. Changing the value of the [Handled](drageventargs_handled.md) property of [DragEventArgs](drageventargs.md) from an event handler can influence how a routed event behaves. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

The [Control](../microsoft.ui.xaml.controls/control.md) class has pre-wired event handlers that [Control](../microsoft.ui.xaml.controls/control.md) derived types can override to provide class-based handling for the drag-drop events,. These methods are:
+ [Control.OnDragEnter](/uwp/api/windows.ui.xaml.controls.control.ondragenter(windows.ui.xaml.drageventargs))
+ [Control.OnDragLeave](/uwp/api/windows.ui.xaml.controls.control.ondragleave(windows.ui.xaml.drageventargs))
+ [Control.OnDragOver](/uwp/api/windows.ui.xaml.controls.control.ondragover(windows.ui.xaml.drageventargs))
+ [Control.OnDrop](/uwp/api/windows.ui.xaml.controls.control.ondrop(windows.ui.xaml.drageventargs))


The Windows Runtime implementation of drag-drop concepts permits only certain controls and input actions to initiate a drag-drop action. There is no generalized **DoDragDrop** method that would permit any UI element to initiate a drag-drop action. The main source of a drag-drop action is when you drag the items of a list such as [GridView](../microsoft.ui.xaml.controls/gridview.md). 

## -examples

## -see-also
[Drag-and-drop overview](/windows/apps/design/input/drag-and-drop), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [DragEventArgs](drageventargs.md)
