---
-api-id: T:Microsoft.UI.Xaml.TextTrimming
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.TextTrimming : int
-->

# TextTrimming

## -description

Describes how text is trimmed when it overflows the edge of its containing box.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<object property="enumMemberName"/>
```

## -enum-fields

### -field None:0

Default.

Text is truncated at a word boundary. 

No trim indicator is drawn and the [RichTextBlock](../microsoft.ui.xaml.controls/richtextblock.md)/[TextBlock](../microsoft.ui.xaml.controls/textblock.md) IsTextTrimmedChanged event does not fire.

### -field CharacterEllipsis:1

Text is trimmed at a character boundary. An ellipsis (...) is drawn in place of remaining text.

### -field WordEllipsis:2

Text is trimmed at a word boundary. An ellipsis (...) is drawn in place of remaining text.

### -field Clip:3

Text is trimmed at a pixel level, visually clipping the excess glyphs.

## -remarks

## -examples

## -see-also

[RichTextBlock.TextTrimming property](../microsoft.ui.xaml.controls/richtextblock_texttrimming.md), [TextBlock.TextTrimming property](../microsoft.ui.xaml.controls/textblock_texttrimming.md)
