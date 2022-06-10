---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.Popup.ShouldConstrainToRootBounds
-api-type: winrt property
---

<!-- Property syntax.
public bool ShouldConstrainToRootBounds { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Primitives.Popup.ShouldConstrainToRootBounds

## -description

Gets or sets a value that indicates whether the popup should be shown within the bounds of the XAML root.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

**true** if the popup should be shown within the bounds of the XAML root; otherwise, **false**. The default is **true**.
> [!NOTE]
> WinUI 3 - **false** is not supported.

## -remarks

This property is applicable only to apps running on the desktop. On other platforms, it does not have an effect. To check if the popup is actually constrained to the root bounds, check the [IsConstrainedToRootBounds](popup_isconstrainedtorootbounds.md) property.

In a UWP app on desktop, when this property is **true**, the popup is shown within the main XAML window handle (HWND). When this property is **false**, the popup is shown in its own top level HWND. In this case, the popup might be positioned to extend beyond the main app window.

When a popup with **ShouldConstrainToRootBounds = false** is first shown, it’s placed in its own window and shown in that context. After it has been shown, ShouldConstrainToRootBounds cannot be set back to **true**.

The _XAML root_ might be a [CoreWindow](/uwp/api/windows.ui.core.corewindow), a [XAML island](/windows/uwp/xaml-platform/xaml-host-controls), or an [AppWindow](/uwp/api/windows.ui.windowmanagement.appwindow).

## -see-also

[IsConstrainedToRootBounds](popup_isconstrainedtorootbounds.md), [FlyoutBase.ShouldConstrainToRootBounds](flyoutbase_shouldconstraintorootbounds.md)

## -examples

