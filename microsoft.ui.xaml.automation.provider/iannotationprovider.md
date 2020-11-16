---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.IAnnotationProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IAnnotationProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.IAnnotationProvider

## -description
Exposes the properties of an annotation in a document. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) call and [PatternInterface.Annotation](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
The **Annotation** control pattern is used to expose the properties of an annotation in a document. One example is a comment balloon that is in the margin of a document and is connected to some document text or a spreadsheet cell. For more info on what this pattern is for, see [Annotation Control Pattern](/windows/desktop/WinAuto/uiauto-implementingannotation).

IAnnotationProvider isn't implemented by any existing Windows Runtime automation peers. The interface exists so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

Use [AnnotationPatternIdentifiers](../microsoft.ui.xaml.automation/annotationpatternidentifiers.md) if you want to reference the IAnnotationProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.raisepropertychangedevent(windows.ui.xaml.automation.automationproperty,system.object,system.object)).

## -examples

## -see-also
[AnnotationPatternIdentifiers](../microsoft.ui.xaml.automation/annotationpatternidentifiers.md), [IAnnotationProvider (COM)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iannotationprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Annotation Control Pattern](/windows/desktop/WinAuto/uiauto-implementingannotation)
