---
-api-id: P:Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.Padding
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness Padding { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.Padding

## -description
Gets or sets a value that indicates the thickness of padding space between the boundaries of the content area and the content displayed by a [RichTextBlockOverflow](richtextblockoverflow.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<RichTextBlockOverflow Padding="uniform"/>
- or -
<RichTextBlockOverflow Padding="left&Right,top&Bottom"/>
- or -
<RichTextBlockOverflow Padding="left,top,right,bottom"/>
```


## -xaml-values
<dl><dt>uniform</dt><dd>uniform A value that specifies a uniform Thickness. The uniform value is applied to all four Thickness properties (Left, Top, Right, Bottom).</dd>
<dt>left&amp;Right</dt><dd>left&amp;Right A value that specifies the Left and Right of a symmetrical Thickness.</dd>
<dt>top&amp;Bottom</dt><dd>top&amp;Bottom A value that specifies the Top and Bottom of a symmetrical Thickness.</dd>
<dt>left right top bottom</dt><dd>left right top bottom Values that specify the four possible dimension properties of a Thickness structure (Left, Top, Right, Bottom).</dd>
</dl>
## -property-value
A [Thickness](../microsoft.ui.xaml/thickness.md) structure that specifies the amount of padding to apply.

## -remarks
[RichTextBlock](richtextblock.md) also has a [Padding](richtextblock_padding.md) property, therefore the padding applied to the [RichTextBlockOverflow](richtextblockoverflow.md) can be different than on the [RichTextBlock](richtextblock.md) associated with it. The padding on the overflow won't default to the value from the associated [RichTextBlock](richtextblock.md), so you'll have to set it manually if you want the same padding on each.

A related property is [Margin](../microsoft.ui.xaml/frameworkelement_margin.md) (a property of [FrameworkElement](../microsoft.ui.xaml/frameworkelement.md)). For more info about the relationship between margin and padding, see [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding) or [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml).

## -examples

## -see-also
[Thickness](../microsoft.ui.xaml/thickness.md), [RichTextBlock](richtextblock.md), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding)
