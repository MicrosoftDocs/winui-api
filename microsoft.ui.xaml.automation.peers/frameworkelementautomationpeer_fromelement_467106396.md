---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer.FromElement(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Automation.Peers.AutomationPeer FromElement(Windows.UI.Xaml.UIElement element)
-->

# Microsoft.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer.FromElement

## -description
Returns the [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) for the specified [UIElement](../microsoft.ui.xaml/uielement.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param element
The [UIElement](../microsoft.ui.xaml/uielement.md) that is associated with this [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md).

## -returns
The [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), or null if the [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) could not be created.

## -remarks
FromElement is a helper class that is used by custom control code to return the acting peer instance. Using the returned peer, you can fire automation events from within the same routines that also fire your general control logic events or change control properties. Or you can write your own helper methods that do this and are invoked from your control logic.

[CreatePeerForElement](frameworkelementautomationpeer_createpeerforelement_865701770.md) has basically the same behavior as FromElement.

If FromElement returns **null**, it's probably because the element you passed does not have an implementation for [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md).

FromElement can return the peer even if the **CreateAutomationPeer** system logic hasn't run yet on the *element* target for some reason. It will invoke the same **CreateAutomationPeer** logic internally in order to get the peer.

## -examples
The automation support design doesn't retain a handle to your own peer as part of how you implement [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md), because there aren't any guarantees of when the peer is actually created. Instead, you can check for run-time automation event listeners inside your control class definitions just-in-time, using code like this:

```csharp
if (AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged))
{
    MyAutomationPeer peer = 
        FrameworkElementAutomationPeer.FromElement(myCtrl) as MyAutomationPeer;

    if (peer != null)
    {
        peer.RaisePropertyChangedEvent(
            RangeValuePatternIdentifiers.ValueProperty,
            (double)oldValue,
            (double)newValue);
    }
}

```

```vbnet
If AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged) Then
    Dim peer As MyDownAutomationPeer = _
    TryCast(FrameworkElementAutomationPeer.FromElement(myCtrl), MyAutomationPeer)
    If peer IsNot Nothing Then
        peer.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.ValueProperty, CDbl(oldValue), CDbl(newValue))
    End If
End If
```



## -see-also
[CreatePeerForElement](frameworkelementautomationpeer_createpeerforelement_865701770.md)
