---
-api-id: M:Microsoft.UI.Windowing.AppWindow.TrySetPresenter(Microsoft.UI.Windowing.AppWindowPresenterKind)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.TrySetPresenter(Microsoft.UI.Windowing.AppWindowPresenterKind)

<!--
public bool TrySetPresenter (Microsoft.UI.Windowing.AppWindowPresenterKind appWindowPresenterKind);
-->

## -description

Attempts to apply the specified presenter kind to the window.

## -parameters

### -param appWindowPresenterKind

The presenter kind to apply to the window.

## -returns

`true` if the presenter was applied to the window; otherwise, `false`.

## -remarks

Call this method with [AppWindowPresenterKind.Default](appwindowpresenterkind.md) as the parameter to apply an [OverlappedPresenter](overlappedpresenter.md).

## -see-also

[AppWindow](appwindow.md)

## -examples
