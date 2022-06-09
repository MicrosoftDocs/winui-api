---
-api-id: T:Microsoft.UI.Xaml.TextWrapping
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.TextWrapping : int
-->

# TextWrapping

## -description

Specifies whether text wraps when it reaches the edge of its container.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<object property="textWrappingMemberName"/>
```

## -enum-fields

### -field NoWrap:1

No line wrapping is performed.

### -field Wrap:2

Line breaking occurs if a line of text overflows beyond the available width of its container. Line breaking occurs even if the text logic can't determine any line break opportunity. For example, if a very long word is constrained in a fixed-width container that can't scroll, it will wrap at a point that might be in the middle of a word.

### -field WrapWholeWords:3

Line-breaking occurs if the line overflows beyond the available block width. A line may overflow beyond the block width if the text logic can't determine a line break opportunity. For example, if a very long word is constrained in a fixed-width container that can't scroll, it will overflow the long word and continue the text after the long word on the next line. Not supported by all controls; see Remarks.

## -remarks

[TextBox](../microsoft.ui.xaml.controls/textbox.md) and [RichEditBox](../microsoft.ui.xaml.controls/richeditbox.md) don't support the **WrapWholeWords** value for their **TextWrapping** properties. If you try to use **WrapWholeWords** as a value for [TextBox.TextWrapping](../microsoft.ui.xaml.controls/textbox_textwrapping.md) or [RichEditBox.TextWrapping](../microsoft.ui.xaml.controls/richeditbox_textwrapping.md) an invalid argument exception is thrown.

## -examples

## -see-also
