---
-api-id: P:Microsoft.UI.Xaml.Window.ExtendsContentIntoTitleBar
-api-type: winrt property
---

# Microsoft.UI.Xaml.Window.ExtendsContentIntoTitleBar

<!--
public bool ExtendsContentIntoTitleBar { get; set; }
-->

## -description

Gets or sets a value that specifies whether the default title bar of the window should be removed to create space for app content.

## -property-value

True, if the default title bar should be removed. Otherwise, false.

## -remarks

Setting this property only affects rendering, it does not affect pointer (such as mouse) behavior. For example, you can still use the mouse to click down in the area at the top of the window and drag the window around the desktop. To change this behavior, use [Window.SetTitleBar](window_settitlebar_1494775390.md).

Extending app content into the title bar does not affect the window buttons (Minimize, Maximize, and Close).

See [Window.SetTitleBar](window_settitlebar_1494775390.md) for an example of this property.

## -see-also

[SetTitleBar](window_settitlebar_1494775390.md), [IWindowNative](/windows/apps/winui/reference/iwindownative)
