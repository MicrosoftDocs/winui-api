---
-api-id: P:Microsoft.UI.Xaml.DragStartingEventArgs.Data
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackage Data { get; }
-->

# Microsoft.UI.Xaml.DragStartingEventArgs.Data

## -description
Gets the data payload associated with a drag action.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
The data payload. The default is an empty [DataPackage](/uwp/api/windows.applicationmodel.datatransfer.datapackage).

## -remarks
In your [DragStarting](uielement_dragstarting.md) event handler, use the [DataPackage.SetData](/uwp/api/windows.applicationmodel.datatransfer.datapackage.setdata(system.string,system.object)) method to provide the data being dragged.

## -examples

## -see-also

[Drag-and-drop overview](/windows/apps/design/input/drag-and-drop)
