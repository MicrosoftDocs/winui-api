---
-api-id: P:Microsoft.UI.Xaml.Controls.RichTextBlock.FontStretch
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Text.FontStretch FontStretch { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.RichTextBlock.FontStretch

## -description
Gets or sets the font stretch for the text content in this element.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<RichTextBlock FontStretch="fontStretchMemberName"/>
```


## -xaml-values
<dl><dt>fontStretchMemberName</dt><dd>fontStretchMemberName A FontStretch named constant, such as Condensed, Normal, or Expanded.</dd>
</dl>
## -property-value
The requested font stretch, as a [FontStretch](/uwp/api/windows.ui.text.fontstretch) constant. The default is Normal.

## -remarks
Set the FontStretch property to specify the default font stretch to use for all text in the [RichTextBlock](richtextblock.md). You can override this value for specific text elements in the [RichTextBlock](richtextblock.md) by setting the [TextElement.FontStretch](../microsoft.ui.xaml.documents/textelement_fontstretch.md) property.

## -examples

## -see-also
[TextElement.FontStretch](../microsoft.ui.xaml.documents/textelement_fontstretch.md)
