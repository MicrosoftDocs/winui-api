---
-api-id: M:Microsoft.UI.Windowing.AppWindow.TrySetPresenter(Microsoft.UI.Windowing.AppWindowPresenter)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.TrySetPresenter(Microsoft.UI.Windowing.AppWindowPresenter)

<!--
public bool TrySetPresenter (Microsoft.UI.Windowing.AppWindowPresenter appWindowPresenter);
-->

## -description

Attempts to apply the specified presenter to the window.

## -parameters

### -param appWindowPresenter

The presenter to apply to the window.

## -returns

`true` if the presenter was applied to the window; otherwise, `false`.

## -remarks

If a presenter has been set, any changes made to that presenter will take effect immediately on the window.

To remove the current presenter from the window, call this method and specify a different presenter.

## -see-also

[AppWindow](appwindow.md)

## -examples
