---
-api-id: P:Microsoft.UI.Xaml.Controls.RichTextBlock.FontWeight
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Text.FontWeight FontWeight { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.RichTextBlock.FontWeight

## -description
Gets or sets the top-level font weight for the [RichTextBlock](richtextblock.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<RichTextBlock FontWeight="fontWeightsMemberName"/>
```


## -xaml-values
<dl><dt>fontWeightsMemberName</dt><dd>fontWeightsMemberNameA FontWeights member name, such as Light or Normal.</dd>
</dl>
## -property-value
The requested font weight, which is a [FontWeight](/uwp/api/windows.ui.text.fontweight) that is obtained from one of the [FontWeights](../microsoft.ui.text/fontweights.md) property values. The default is [Normal](../microsoft.ui.text/fontweights_normal.md).

## -remarks
Set the FontWeight property to specify the default font stretch to use for all text in the [RichTextBlock](richtextblock.md). You can override this value for specific text elements in the [RichTextBlock](richtextblock.md) by setting the [TextElement.FontWeight](../microsoft.ui.xaml.documents/textelement_fontweight.md) property.

## -examples

## -see-also
[TextElement.FontWeight](../microsoft.ui.xaml.documents/textelement_fontweight.md)
