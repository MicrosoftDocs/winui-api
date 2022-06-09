---
-api-id: T:Microsoft.UI.Xaml.Controls.LightDismissOverlayMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.LightDismissOverlayMode : int
-->

# LightDismissOverlayMode

## -description
Defines constants that specify whether the area outside of a *light-dismiss* UI is darkened.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields
### -field Auto:0
The device-family the app is running on determines whether the area outside of a *light-dismiss* UI is darkened.

### -field On:1
The area outside of a *light-dismiss* UI is darkened for all device families.

### -field Off:2
The area outside of a *light-dismiss* UI is not darkened for all device families.


## -remarks
Transient UI, such as a [Flyout](flyout.md) or the open drop-down of a [ComboBox](combobox.md), closes when you click or tap outside of it. This is called light-dismiss. "Overlay" refers to the area outside of a light-dismiss UI.

By default, the "overlay" is darkened on the Xbox, and not darkened on other devices families. You can set [LightDismissOverlayMode](../microsoft.ui.xaml.controls.primitives/flyoutbase_lightdismissoverlaymode.md) to **On** to make your app darken the "overlay" area on all device families, or set it to **Off** to not darken the "overlay" area on all device families.

## -examples

## -see-also
