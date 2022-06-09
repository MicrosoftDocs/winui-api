---
-api-id: P:Microsoft.UI.Xaml.BringIntoViewOptions.TargetRect
-api-type: winrt property
---

<!-- Property syntax.
public IReference<Rect> TargetRect { get;  set; }
-->

# Microsoft.UI.Xaml.BringIntoViewOptions.TargetRect

## -description
Gets or sets the area of an element to bring into view.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
A rectangle that defines the area of an element to bring into view.

## -remarks
Set the TargetRect to specify a particular part of an element to be brought into view. For example, if you need to scroll a large image into view, you could define a specific part of the image that should be made visible. If the TargetRect is **null**, the element's bounding rect is used as the target.

## -see-also


## -examples

