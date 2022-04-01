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

`true` if the default title bar should be hidden; otherwise, `false`.

## -remarks

Use this property in conjunction with the [SetTitleBar](window_settitlebar_1494775390.md) method to replace your app window's system title bar with custom content. See [SetTitleBar](window_settitlebar_1494775390.md) for more info and an example.

To specify a custom title bar, you must set `ExtendsContentIntoTitleBar` to `true` to hide the default system title bar. If `ExtendsContentIntoTitleBar` is `false`, a call to `SetTitleBar` does not have any effect. Your custom title bar element is shown in the body of your app window as an ordinary UI element and does not get the title bar behaviors.

If you set `ExtendsContentIntoTitleBar` to `true` but do not call `SetTitleBar`, the system title bar is restricted to the caption buttons and a small area next to the caption buttons that is reserved for title bar behaviors. It is called Fallback Titlebar. However, your custom title bar element does not get title bar behaviors, such as drag and the system menu, until [SetTitleBar](window_settitlebar_1494775390.md) is called with a valid [UIElement](uielement.md).

## -see-also

[SetTitleBar](window_settitlebar_1494775390.md), [IWindowNative](/windows/apps/winui/reference/iwindownative)
