---
-api-id: T:Microsoft.UI.Xaml.FocusVisualKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.FocusVisualKind : int
-->

# FocusVisualKind

## -description

Specifies the visual feedback used to indicate the UI element with focus when navigating with a keyboard or gamepad.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -enum-fields

### -field DottedLine:0

A dotted line rectangle. Also known as "marching ants". 

The default on Windows 10 November Update (Windows 10 version 1511 - build number 10.0.10586, codenamed "Threshold 2") and earlier.

### -field HighVisibility:1

A solid line rectangle composed of an inner and outer rectangle of contrasting colors.

The default on Windows 10 Anniversary Update (Windows 10 version 1607 - build number 10.0.14393, codenamed "Redstone 1") and earlier. 

DottedLine visual is difficult to see in 10-foot experience.

### -field Reveal:2

A solid line rectangle, surrounded by a glowing light effect to simulate depth. 

Opt-in feature for Xbox with Windows 10 version 1803 (codenamed "Redstone 4") and later.

## -remarks

## -examples

## -see-also

[FocusVisualKind](/uwp/api/windows.ui.xaml.application.FocusVisualKind)
