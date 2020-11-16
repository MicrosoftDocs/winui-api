---
-api-id: P:Microsoft.UI.Xaml.Controls.RichTextBlock.FontStyle
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Text.FontStyle FontStyle { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.RichTextBlock.FontStyle

## -description
Gets or sets the font style for the content in this element.

## -xaml-syntax
```xaml
<RichTextBlock FontStyle="fontStyleMemberName"/>
```


## -xaml-values
<dl><dt>fontStyleMemberName</dt><dd>fontStyleMemberName A FontStyle member name, such as Italic.</dd>
</dl>
## -property-value
The requested font style, which is a [FontStyle](/uwp/api/windows.ui.text.fontstyle) enumeration named constant. The default is Normal.

## -remarks
Set the FontStyle property to specify the default font stretch to use for all text in the [RichTextBlock](richtextblock.md). You can override this value for specific text elements in the [RichTextBlock](richtextblock.md) by setting the [TextElement.FontStyle](../microsoft.ui.xaml.documents/textelement_fontstyle.md) property.

## -examples

## -see-also
[TextElement.FontStyle](../microsoft.ui.xaml.documents/textelement_fontstyle.md)
