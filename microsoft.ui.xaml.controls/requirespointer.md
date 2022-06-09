---
-api-id: T:Microsoft.UI.Xaml.Controls.RequiresPointer
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.RequiresPointer : int
-->

# RequiresPointer

## -description
Defines constants that specify when an element requires a mouse-like pointer behavior from a game pad.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -enum-fields
### -field Never:0
The pointer never acts as a mouse.

### -field WhenEngaged:1
The pointer acts as a mouse when the user engages mouse-mode.

### -field WhenFocused:2
The pointer acts as a mouse when the page gets focus. Supported on [Page](page.md) elements only.


## -remarks
This enumeration provides values for the [Control.RequiresPointer](control_requirespointer.md) property.

[RequiresPointer](control_requirespointer.md) is supported only on the Xbox device family, and only when using a game pad or remote control. The property is ignored otherwise.

## -examples

## -see-also
