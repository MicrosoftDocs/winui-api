---
-api-id: T:Microsoft.UI.Windowing.AppWindowPresenterKind
-api-type: winrt enum
---

# Microsoft.UI.Windowing.AppWindowPresenterKind

<!--
public enum AppWindowPresenterKind
-->

## -description

Defines constants that specify the kind of presenter the app window uses.

## -enum-fields

### -field Default: 0

The app window uses the system default presenter.

### -field CompactOverlay: 1

The app window uses a compact overlay (picture-in-picture) presenter.

### -field FullScreen: 2

The app window uses a full screen presenter.

### -field Overlapped: 3

The app window uses an overlapped presenter.

## -remarks

> [!NOTE]
> The `Default` value is used only when you apply an [AppWindowPresenter](appwindowpresenter.md) by _kind_ ([AppWindow.TrySetPresenter(appWindowPresenterKind)](appwindow_trysetpresenter_521479597.md)), it is never used as the value of the [Kind](appwindowpresenter_kind.md) property of any presenter.
>
>The default presenter is [OverlappedPresenter](overlappedpresenter.md), which means that calling `AppWindow.TrySetPresenter(AppWindowPresenterKind.Default)` will result in an `OverlappedPresenter` being applied to the window.

## -see-also

[AppWindowPresenter.Kind](appwindowpresenter_kind.md), [AppWindow.TrySetPresenter(appWindowPresenterKind)](appwindow_trysetpresenter_521479597.md), [CompactOverlayPresenter](compactoverlaypresenter.md), [FullScreenPresenter](fullscreenpresenter.md), [OverlappedPresenter](overlappedpresenter.md)

## -examples
