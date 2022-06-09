---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.ScrollBarAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ScrollBarAutomationPeer : Windows.UI.Xaml.Automation.Peers.RangeBaseAutomationPeer, Windows.UI.Xaml.Automation.Peers.IScrollBarAutomationPeer
-->

# Microsoft.UI.Xaml.Automation.Peers.ScrollBarAutomationPeer

## -description
Exposes [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md) types to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
The Windows Runtime  [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md) class creates a new ScrollBarAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md) is sealed, so the normal scenario of deriving from the [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md) class and its existing peer isn't applicable to ScrollBarAutomationPeer.

### Default peer implementation and overrides in **ScrollBarBarAutomationPeer**

ScrollBarAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) defers to base peers. [GetPattern](automationpeer_getpattern_1700082720.md) returns a pattern for [IRangeValueProvider](../microsoft.ui.xaml.automation.provider/irangevalueprovider.md) though the base [RangeBaseAutomationPeer](rangebaseautomationpeer.md).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ScrollBar".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ScrollBar](automationcontroltype.md).
+ [GetClickablePoint](automationpeer_getclickablepoint_955785073.md) returns a "not a number"[Point](/uwp/api/windows.foundation.point) value that indicates that there isn't just one such point; clicking at various points along the range has different results.
+ [GetOrientation](automationpeer_getorientation_419829207.md) reports a value that parallels the [Orientation](../microsoft.ui.xaml.controls.primitives/scrollbar_orientation.md) of the [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md) owner.
+ [IsContentElement](automationpeer_iscontentelement_545450603.md) returns **false**.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[RangeBaseAutomationPeer](rangebaseautomationpeer.md), [IRangeValueProvider](../microsoft.ui.xaml.automation.provider/irangevalueprovider.md), [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
