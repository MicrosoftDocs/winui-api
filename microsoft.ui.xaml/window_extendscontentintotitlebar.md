---
-api-id: P:Microsoft.UI.Xaml.Window.ExtendsContentIntoTitleBar
-api-type: winrt property
---

# Microsoft.UI.Xaml.Window.ExtendsContentIntoTitleBar

<!--
public bool ExtendsContentIntoTitleBar { get; set; }
-->


## -description
Gets or sets a value that specifies whether the default window title bar should be removed, creating more space for content.

Setting this property to true causes the built-in title bar to be removed.

## -property-value

## -remarks
Setting this property only effects rendering, it does not affect pointer (such as mouse) behavior. 
For example, you can still use the mouse to click down in the area at the top of the window and 
drag the window around the desktop. To change that behavior, use the [Window.SetTitleBar](window_settitlebar_1494775390.md) API.

Extending the content into the title bar does not impact the Window buttons 
(Minimize, Maximize, and Close).

See  [Window.SetTitleBar](window_settitlebar_1494775390.md) for an example of ExtendsContentIntoTitleBar.

## -see-also

- [SetTitleBar](window_settitlebar_1494775390.md)


