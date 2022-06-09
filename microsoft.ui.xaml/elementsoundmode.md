---
-api-id: T:Microsoft.UI.Xaml.ElementSoundMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.ElementSoundMode : int
-->

# ElementSoundMode

## -description
Defines constants that specify a control's preference for whether sounds are played.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -enum-fields
### -field Default:0
Sound is played based on the [ElementSoundPlayer.State](elementsoundplayer_state.md) setting.

### -field FocusOnly:1
Sound is played only when focus on the control changes.

### -field Off:2
No sounds are played.


## -remarks
This enumeration is used by the **ElementSoundMode** property on [Control](../microsoft.ui.xaml.controls/control_elementsoundmode.md), [FlyoutBase](../microsoft.ui.xaml.controls.primitives/flyoutbase_elementsoundmode.md), and [Hyperlink](../microsoft.ui.xaml.documents/hyperlink_elementsoundmode.md).

For more info, see [Sound in UWP apps](/windows/uwp/style/sound).

## -examples

## -see-also
[Sound in UWP apps](/windows/uwp/style/sound), [ElementSoundPlayer.State](elementsoundplayer_state.md), [ElementSoundPlayer](elementsoundplayer.md), [Control.ElementSoundMode](../microsoft.ui.xaml.controls/control_elementsoundmode.md), [FlyoutBase.ElementSoundMode](../microsoft.ui.xaml.controls.primitives/flyoutbase_elementsoundmode.md), [Hyperlink.ElementSoundMode](../microsoft.ui.xaml.documents/hyperlink_elementsoundmode.md)
