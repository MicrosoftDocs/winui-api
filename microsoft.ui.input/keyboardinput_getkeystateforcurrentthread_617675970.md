---
-api-id: M:Microsoft.UI.Input.KeyboardInput.GetKeyStateForCurrentThread(Windows.System.VirtualKey)
-api-type: winrt method
---

# Microsoft.UI.Input.KeyboardInput.GetKeyStateForCurrentThread(Windows.System.VirtualKey)

<!--
public static Windows.UI.Core.CoreVirtualKeyStates GetKeyStateForCurrentThread (Windows.System.VirtualKey virtualKey);
-->

## -description

Retrieves the state of a virtual key.

## -parameters

The virtual key for which the state is returned.

### -param virtualKey

## -returns

The flags indicating the current state of the supplied virtual key when the input event fired.

> [!NOTE]
> All keys support the Locked state (not just the standard Caps Lock and Num Lock keys).

## -remarks

## -see-also

[CoreVirtualKeyStates enum](/uwp/api/windows.ui.core.corevirtualkeystates), [VirtualKey enum](/uwp/api/windows.system.virtualkey)

## -examples
