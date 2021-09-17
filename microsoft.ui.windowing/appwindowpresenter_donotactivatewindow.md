---
-api-id: P:Microsoft.UI.Windowing.AppWindowPresenter.DoNotActivateWindow
-api-type: winrt property
---

# Microsoft.UI.Windowing.AppWindowPresenter.DoNotActivateWindow

<!--
public bool DoNotActivateWindow { get; set; }
-->

## -description

Gets or sets a value that indicates whether the window should not be activated when the presenter is applied.

## -property-value

`true` if the window should not be activated when the presenter is applied; otherwise, `false`. The default is `false`.

## -remarks

This value takes effect only when calling [AppWindow.TrySetPresenter](appwindow_trysetpresenter_1163153038.md). Changing the value on an already applied presenter will not change the window's active state.

## -see-also

[AppWindowPresenter](appwindowpresenter.md)

## -examples
