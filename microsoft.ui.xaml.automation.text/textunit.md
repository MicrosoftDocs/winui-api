---
-api-id: T:Microsoft.UI.Xaml.Automation.Text.TextUnit
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Automation.Text.TextUnit : int
-->

# TextUnit

## -description
Represents predefined units of text for the purposes of navigation within a document.

## -enum-fields
### -field Character:0
Specifies that the text unit is one character in length.

### -field Format:1
Specifies that the text unit is the length of a single, common format specification, such as bold, italic, or similar.

### -field Word:2
Specifies that the text unit is one word in length.

### -field Line:3
Specifies that the text unit is one line in length.

### -field Paragraph:4
Specifies that the text unit is one paragraph in length.

### -field Page:5
Specifies that the text unit is one document-specific page in length.

### -field Document:6
Specifies that the text unit is an entire document in length.


## -remarks
TextUnit defines an input for the [Move](/uwp/api/windows.ui.text.itextrange.move(windows.ui.text.textrangeunit,system.int32)) method and related methods of the **TextRange** automation control pattern. [ITextRangeProvider](../microsoft.ui.xaml.automation.provider/itextrangeprovider.md) is the definition interface if you want to support the **TextRange** automation pattern as part of a Windows Runtime custom control. For more info, see [ITextRangeProvider](../microsoft.ui.xaml.automation.provider/itextrangeprovider.md) or [Text and TextRange Control Patterns](/windows/desktop/WinAuto/uiauto-implementingtextandtextrange).

## -examples

## -see-also
[ITextRangeProvider](../microsoft.ui.xaml.automation.provider/itextrangeprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
