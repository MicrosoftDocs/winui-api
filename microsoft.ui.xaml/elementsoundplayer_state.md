---
-api-id: P:Microsoft.UI.Xaml.ElementSoundPlayer.State
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.ElementSoundPlayerState State { get;  set; }
-->

# Microsoft.UI.Xaml.ElementSoundPlayer.State

## -description
Gets or sets a value that specifies whether the system plays control sounds.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
A value of the enumeration that specifies whether the system plays control sounds. The default is **Auto**.

## -remarks
By default, control sounds are played on the Xbox, and are not played on other devices families. You can set [ElementSoundPlayerState](elementsoundplayerstate.md) to **On** to make your app play sounds on all device families, or set it to **Off** to disable sounds on all device families.

For more info, see [Sound in UWP apps](/windows/uwp/style/sound).

## -examples

## -see-also
