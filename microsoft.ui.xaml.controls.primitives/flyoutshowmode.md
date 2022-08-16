---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.FlyoutShowMode
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum FlyoutShowMode : int 
-->

# Microsoft.UI.Xaml.Controls.Primitives.FlyoutShowMode

## -description

Defines constants that specify how a flyout behaves when shown.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields

### -field Auto:0

The show mode is determined automatically based on the method used to show the flyout.

### -field Standard:1

Behavior is typical of a flyout shown reactively, like a context menu. The open flyout takes focus. For a CommandBarFlyout, it opens in it's expanded state.

### -field Transient:2

Behavior is typical of a flyout shown proactively. The open flyout does not take focus. For a CommandBarFlyout, it opens in it's collapsed state.

### -field TransientWithDismissOnPointerMoveAway:3

The flyout exhibits Transient behavior while the cursor is close to it, but is dismissed when the cursor moves away.

## -remarks

## -see-also

[FlyoutShowOptions.ShowMode](flyoutshowoptions_showmode.md)

## -examples
