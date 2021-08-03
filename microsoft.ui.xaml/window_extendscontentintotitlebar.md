---
-api-id: P:Microsoft.UI.Xaml.Window.ExtendsContentIntoTitleBar
-api-type: winrt property
---

# Microsoft.UI.Xaml.Window.ExtendsContentIntoTitleBar

<!--
public bool ExtendsContentIntoTitleBar { get; set; }
-->

## -description

Gets or sets a value that specifies whether the default title bar of the window should be hidden to create space for app content.

## -property-value

True, if the default title bar should be hidden. Otherwise, false.

## -remarks

The following two steps are required when specifying a custom window title bar:

1. Set this property to true to hide the Windows default title bar and allocate space for a custom title bar.
2. Call [SetTitleBar](window_settitlebar_1494775390.md) with your [UIElement](uielement.md).

If you skip step 1, the default title bar is not hidden and your custom title bar is not shown.
If you skip step 2, a small area next to the min/max/close buttons is allocated for the custom title bar until [SetTitleBar](window_settitlebar_1494775390.md) is called with a valid UIElement.

See [SetTitleBar](window_settitlebar_1494775390.md) for an example.

Setting this property only affects rendering, it does not affect pointer (such as mouse) behavior. For example, you can still use the mouse to click down in the area at the top of the window and drag the window around the desktop. To change this behavior, use [SetTitleBar](window_settitlebar_1494775390.md).

Extending app content into the title bar does not affect the window buttons (Minimize, Maximize, and Close).

## -see-also

[SetTitleBar](window_settitlebar_1494775390.md), [IWindowNative](/windows/apps/winui/reference/iwindownative)
