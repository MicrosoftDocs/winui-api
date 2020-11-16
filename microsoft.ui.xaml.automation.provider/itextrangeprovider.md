---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ITextRangeProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider

## -description
Exposes methods and properties to support Microsoft UI Automation client access to a span of continuous text in a text container that implements [ITextProvider](itextprovider.md).

## -remarks
For more info on this pattern, see [Text and TextRange Control Patterns](/windows/desktop/WinAuto/uiauto-implementingtextandtextrange).

[ITextProvider](itextprovider.md), [ITextProvider2](itextprovider2.md) and ITextRangeProvider aren't implemented by any existing Windows Runtime automation peers using this definition of the interface. The text models supported by Windows Runtime text controls such as [TextBox](../microsoft.ui.xaml.controls/textbox.md) and [RichTextBlock](../microsoft.ui.xaml.controls/richtextblock.md) do implement some of these patterns, but do so at a native level that doesn't appear in the Windows Runtime definitions of the API surface. For more info, see the peer classes for the various Windows Runtime text controls.

The ITextRangeProvider pattern doesn't have a Windows Runtime property identifier class.

## -examples

## -see-also
[Text and TextRange Control Patterns](/windows/desktop/WinAuto/uiauto-implementingtextandtextrange), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [ITextRangeProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-itextrangeprovider), [ITextProvider](itextprovider.md)
