---
-api-id: P:Microsoft.UI.Xaml.DragEventArgs.Modifiers
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DragDrop.DragDropModifiers Modifiers { get; }
-->

# Microsoft.UI.Xaml.DragEventArgs.Modifiers

## -description
Gets a flag enumeration indicating the current state of the SHIFT, CTRL, and ALT keys, as well as the state of the mouse buttons.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
One or more members of the [DragDropModifiers](/uwp/api/windows.applicationmodel.datatransfer.dragdrop.dragdropmodifiers) flag enumeration.

## -remarks
The effect of a drag-and-drop operation can be adjusted depending on the state of a particular key. For example, data may either be copied or moved depending on whether the CTRL or SHIFT keys are pressed during the drag-and-drop operation.

## -examples

## -see-also

[Drag-and-drop overview](/windows/apps/design/input/drag-and-drop)
