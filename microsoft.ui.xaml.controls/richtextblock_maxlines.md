---
-api-id: P:Microsoft.UI.Xaml.Controls.RichTextBlock.MaxLines
-api-type: winrt property
---

<!-- Property syntax
public int MaxLines { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.RichTextBlock.MaxLines

## -description
Gets or sets the maximum lines of text shown in the [RichTextBlock](richtextblock.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<RichTextBlock MaxLines="int"/>
```


## -property-value
The maximum lines of text shown in the [RichTextBlock](richtextblock.md). The default is 0, which is a special value that represents "Auto" behavior. The value cannot be negative.

## -remarks
Use the **MaxLines** property to specify the maximum lines of text shown in a text block. The text control will adjust it’s height to show no more than the specified number of lines, regardless of the font size, font style, or text length.

Negative integer values are invalid, and will cause a run-time exception.

## -examples

## -see-also
