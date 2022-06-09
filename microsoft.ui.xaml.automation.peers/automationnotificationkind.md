---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.AutomationNotificationKind
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum AutomationNotificationKind : int
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationNotificationKind

## -description
Indicates the type of notification when calling [RaiseNotificationEvent](automationpeer_raisenotificationevent_331851708.md)

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields
### -field ItemAdded:0
The current element container has had something added to it that should be presented to the user.

### -field ItemRemoved:1
The current element has had something removed from inside it that should be presented to the user.

### -field ActionCompleted:2
The current element has a notification that an action was completed.

### -field ActionAborted:3
The current element has a notification that an action was abandoned.

### -field Other:4
The current element has a notification not an add, remove, completed, or aborted action.

## -remarks

## -see-also

## -examples
