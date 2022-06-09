---
-api-id: P:Microsoft.UI.Xaml.Controls.RichTextBlock.OverflowContentTarget
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.RichTextBlockOverflow OverflowContentTarget { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.RichTextBlock.OverflowContentTarget

## -description
Gets or sets a reference to a [RichTextBlockOverflow](richtextblockoverflow.md) that is the linked target for any text overflow from this [RichTextBlock](richtextblock.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
RichTextBlock OverflowContentTarget="{Binding ElementName=nameOfTarget}" />
```


## -xaml-values
<dl><dt>nameOfTarget</dt><dd>nameOfTargetThe x:Name or reference name of an existing RichTextBlockOverflow element in the same . Note that this usage assumes that the source and target are in the same data context.</dd>
</dl>
## -property-value
The target for overflow.

## -remarks

## -examples

## -see-also
[HasOverflowContent](richtextblock_hasoverflowcontent.md), [RichTextBlockOverflow](richtextblockoverflow.md)
