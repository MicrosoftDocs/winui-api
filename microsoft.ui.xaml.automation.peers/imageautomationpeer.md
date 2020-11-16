---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.ImageAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ImageAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IImageAutomationPeer
-->

# Microsoft.UI.Xaml.Automation.Peers.ImageAutomationPeer

## -description
Exposes [Image](../microsoft.ui.xaml.controls/image.md) types to Microsoft UI Automation.

## -remarks
The Windows Runtime  [Image](../microsoft.ui.xaml.controls/image.md) class creates a new ImageAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [Image](../microsoft.ui.xaml.controls/image.md) is sealed, so the normal scenario of deriving from the class and its existing peer isn't applicable to ImageAutomationPeer.

Also, the [Image](../microsoft.ui.xaml.controls/image.md) isn't focusable, which limits its participation in a Microsoft UI Automation tree view of the UI. There are techniques for increasing the accessibility visibility of images in UI, such as applying labels or visible captions. For more info, see "Accessible names for images" section of [Basic accessibility information](/windows/uwp/accessibility/basic-accessibility-information).

### Default peer implementation and overrides in **ImageAutomationPeer**

ImageAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports no pattern support.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "Image".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Image](automationcontroltype.md).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[Image](../microsoft.ui.xaml.controls/image.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Basic accessibility information](/windows/uwp/accessibility/basic-accessibility-information), [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes)
