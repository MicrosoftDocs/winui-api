---
-api-id: T:Microsoft.UI.Xaml.Controls.RichTextBlock
-api-type: winrt class
---

<!-- Class syntax.
public class RichTextBlock : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.IRichTextBlock, Windows.UI.Xaml.Controls.IRichTextBlock2, Windows.UI.Xaml.Controls.IRichTextBlock3, Windows.UI.Xaml.Controls.IRichTextBlock4
-->

# Microsoft.UI.Xaml.Controls.RichTextBlock

## -description
Represents a rich text display container that supports formatted text, hyperlinks, inline images, and other rich content. RichTextBlock supports a built-in overflow model.

## -xaml-syntax
```xaml
<RichTextBlock .../>
-or-
<RichTextBlock ...>
  blocksContent
</RichTextBlock>
```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Rich text block](/windows/apps/design/controls/rich-text-block).

The RichTextBlock control displays read-only text, and provides several features for advanced text layout. Use a RichTextBlock when you need support for paragraphs, inline UI elements, or overflow text.

[TextBlock](textblock.md) provides a simpler content model, so it's typically easier to use, and it can provide better text rendering performance than RichTextBlock. It also provides many of the same formatting options for customizing how your text is rendered. However, RichTextBlock provides several unique features that [TextBlock](textblock.md) doesn't provide.

For more info and examples, see the [RichTextBlock control guide](/windows/uwp/controls-and-patterns/rich-text-block).

### Paragraphs and formatting

The content property of RichTextBlock is the [Blocks](richtextblock_blocks.md) property, which is based on the [Paragraph](../microsoft.ui.xaml.documents/paragraph.md) element. Set the indentation for paragraphs by setting the [TextIndent](richtextblock_textindent.md) property.

You can use text elements and the attached properties of the [Typography](../microsoft.ui.xaml.documents/typography.md) class to apply character and paragraph formatting to the text in the RichTextBlock. For example, you can apply [Bold](../microsoft.ui.xaml.documents/bold.md), [Italic](../microsoft.ui.xaml.documents/italic.md), and [Underline](../microsoft.ui.xaml.documents/underline.md) to any portion of the text in the control.

### Inline UI elements

You can use an [InlineUIContainer](../microsoft.ui.xaml.documents/inlineuicontainer.md) in the content of a RichTextBlock to embed elements that are derived from [UIElement](../microsoft.ui.xaml/uielement.md), such as images, in your text.

### Overflow content

You can use a RichTextBlock with [RichTextBlockOverflow](richtextblockoverflow.md) elements to create advanced page layouts, such as multi-column text. The content for a [RichTextBlockOverflow](richtextblockoverflow.md) element always comes from a RichTextBlock element. You link [RichTextBlockOverflow](richtextblockoverflow.md) elements by setting them as the [OverflowContentTarget](richtextblock_overflowcontenttarget.md) of a RichTextBlock or another [RichTextBlockOverflow](richtextblockoverflow.md).

### Font fallback

The default [FontFamily](richtextblock_fontfamily.md) for RichTextBlock is Segoe UI and the default [FontSize](richtextblock_fontsize.md) is 15 device-independent pixel (DIP). By default, RichTextBlock utilizes a font fallback mechanism to show glyphs that are not included in the specified font. If the glyph that is needed in a RichTextBlock is not available in the specified font, the font fallback mechanism goes through a list of fonts on the system to try and display the required characters in a different font.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Rich text block](/windows/apps/design/controls/rich-text-block).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/RichTextBlock) or [**WinUI 2 Gallery**](winui2gallery:/item/RichTextBlock).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


This example shows a RichTextBlock with text selection and text wrapping enabled.

In XAML, the creation of content elements is implicit, so you can add the text directly to the [Paragraph](../microsoft.ui.xaml.documents/paragraph.md) element, and the [Paragraph](../microsoft.ui.xaml.documents/paragraph.md) directly to the RichTextBlock element.

In code, you have to explicitly create each [Run](../microsoft.ui.xaml.documents/run.md) element, set its [Text](../microsoft.ui.xaml.documents/run_text.md) property, and add it to the [Paragraph.Inlines](../microsoft.ui.xaml.documents/paragraph_inlines.md) collection. Then, add each [Paragraph](../microsoft.ui.xaml.documents/paragraph.md) to the [RichTextBlock.Blocks](richtextblock_blocks.md) collection.

```xaml
<RichTextBlock IsTextSelectionEnabled="True" TextWrapping="Wrap" Width="200" >
    <Paragraph>
        This is some sample text to show the wrapping behavior.
    </Paragraph>
</RichTextBlock>
```

```csharp
// Create a RichTextBlock, a Paragraph and a Run.
RichTextBlock richTextBlock = new RichTextBlock();
Paragraph paragraph = new Paragraph();
Run run = new Run();

// Customize some properties on the RichTextBlock.
richTextBlock.IsTextSelectionEnabled = true;
richTextBlock.TextWrapping = TextWrapping.Wrap;
run.Text = "This is some sample text to show the wrapping behavior.";
richTextBlock.Width = 200;

// Add the Run to the Paragraph, the Paragraph to the RichTextBlock.
paragraph.Inlines.Add(run);
richTextBlock.Blocks.Add(paragraph);

// Add the RichTextBlock to the visual tree (assumes stackPanel is decalred in XAML).
stackPanel.Children.Add(richTextBlock);
```

This example shows a RichTextBlock with customization of [FontWeight](richtextblock_fontweight.md), [FontFamily](richtextblock_fontfamily.md), [FontStyle](richtextblock_fontstyle.md), [Foreground](richtextblock_foreground.md), and [SelectionHighlightColor](richtextblock_selectionhighlightcolor.md) for a single run of text.

In XAML, the creation of content elements is implicit, so you can add the text directly to the [Paragraph](../microsoft.ui.xaml.documents/paragraph.md) element, and the [Paragraph](../microsoft.ui.xaml.documents/paragraph.md) directly to the RichTextBlock element.

In code, you have to explicitly create each [Run](../microsoft.ui.xaml.documents/run.md) element, set its [Text](../microsoft.ui.xaml.documents/run_text.md) property, and add it to the [Paragraph.Inlines](../microsoft.ui.xaml.documents/paragraph_inlines.md) collection. Then, add each [Paragraph](../microsoft.ui.xaml.documents/paragraph.md) to the [RichTextBlock.Blocks](richtextblock_blocks.md) collection.

```xaml
<RichTextBlock IsTextSelectionEnabled="True" SelectionHighlightColor="Pink" 
               FontWeight="Light" FontFamily="Arial" FontStyle="Italic" 
               Foreground="Blue">
    <Paragraph>
        This is some sample text to demonstrate some properties.
    </Paragraph>
</RichTextBlock>
```

```csharp
// Create a RichTextBlock, a Paragraph and a Run.
RichTextBlock richTextBlock = new RichTextBlock();
Paragraph paragraph = new Paragraph();
Run run = new Run();

// Customize some properties on the RichTextBlock.
richTextBlock.IsTextSelectionEnabled = true;
richTextBlock.SelectionHighlightColor = new SolidColorBrush(Windows.UI.Colors.Pink);
richTextBlock.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
richTextBlock.FontWeight = Windows.UI.Text.FontWeights.Light;
richTextBlock.FontFamily = new FontFamily("Arial");
richTextBlock.FontStyle = Windows.UI.Text.FontStyle.Italic;
run.Text = "This is some sample text to demonstrate some properties.";

//Add the Run to the Paragraph, the Paragraph to the RichTextBlock.
paragraph.Inlines.Add(run);
richTextBlock.Blocks.Add(paragraph);

// Add the RichTextBlock to the visual tree (assumes stackPanel is decalred in XAML).
stackPanel.Children.Add(richTextBlock);
```

This example shows a RichTextBlock with customization of [FontWeight](richtextblock_fontweight.md), [FontFamily](richtextblock_fontfamily.md), [FontStyle](richtextblock_fontstyle.md), [Foreground](richtextblock_foreground.md), and [SelectionHighlightColor](richtextblock_selectionhighlightcolor.md) for different runs of text.

In XAML, the creation of content elements is implicit, so you can add the text directly to the [Paragraph](../microsoft.ui.xaml.documents/paragraph.md) element, and the [Paragraph](../microsoft.ui.xaml.documents/paragraph.md) directly to the RichTextBlock element.

In code, you have to explicitly create each [Run](../microsoft.ui.xaml.documents/run.md) element, set its [Text](../microsoft.ui.xaml.documents/run_text.md) property, and add it to the [Paragraph.Inlines](../microsoft.ui.xaml.documents/paragraph_inlines.md) collection. Then, add each [Paragraph](../microsoft.ui.xaml.documents/paragraph.md) to the [RichTextBlock.Blocks](richtextblock_blocks.md) collection.

```xaml
<RichTextBlock IsTextSelectionEnabled="True" SelectionHighlightColor="Pink" FontFamily="Arial"  >
    <Paragraph>
        <Run Foreground="Blue" FontWeight="Light" Text="This is some" ></Run>
        <Span FontWeight="SemiBold">
            <Run FontStyle="Italic">sample text to</Run>
            <Run Foreground="Red">demonstrate some properties.</Run>
        </Span>
    </Paragraph>
</RichTextBlock>
```

```csharp
RichTextBlock richTextBlock = new RichTextBlock();
richTextBlock.IsTextSelectionEnabled = true;
richTextBlock.SelectionHighlightColor = new SolidColorBrush(Windows.UI.Colors.Pink);
richTextBlock.FontFamily = new FontFamily("Arial");

Paragraph paragraph = new Paragraph();
Run run = new Run();
run.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
run.FontWeight = Windows.UI.Text.FontWeights.Light;
run.Text = "This is some";

Span span = new Span();
span.FontWeight = Windows.UI.Text.FontWeights.SemiBold;

Run run1 = new Run();
run1.FontStyle = Windows.UI.Text.FontStyle.Italic;
run1.Text = " sample text to ";

Run run2 = new Run();
run2.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
run2.Text = " demonstrate some properties";

span.Inlines.Add(run1);
span.Inlines.Add(run2);
paragraph.Inlines.Add(run);
paragraph.Inlines.Add(span);
richTextBlock.Blocks.Add(paragraph);

// Add the RichTextBlock to the visual tree (assumes stackPanel is decalred in XAML).
stackPanel.Children.Add(richTextBlock);
```

Here, a RichTextBlock targets a [RichTextBlockOverflow](richtextblockoverflow.md) element to create a multi-column text layout. The first [RichTextBlockOverflow](richtextblockoverflow.md) element then targets a second [RichTextBlockOverflow](richtextblockoverflow.md) element that receives its content overflow. The controlling layout factor for how the text overflow is calculated is the constrained [Width](../microsoft.ui.xaml/frameworkelement_width.md) and [Height](../microsoft.ui.xaml/frameworkelement_height.md) of the parent [Grid](grid.md), and the [ColumnDefinition](columndefinition.md) settings that divide the [Grid](grid.md) into three equal columns of 300 pixels height/width. Overflow is also affected by [FontSize](richtextblock_fontsize.md) and many other text formatting properties that change characters in the text.



[!code-xaml[RichTextOverflow](../microsoft.ui.xaml.controls/code/TextDisplaySnippets/CS/MainPage.xaml#SnippetRichTextOverflow)]

## -see-also
[Rich text block overview](/windows/apps/design/controls/rich-text-block), [Paragraph](../microsoft.ui.xaml.documents/paragraph.md), [OverflowContentTarget](richtextblock_overflowcontenttarget.md), [RichTextBlockOverflow](richtextblockoverflow.md), [RichTextBlockOverflow.OverflowContentTarget](richtextblockoverflow_overflowcontenttarget.md), [XAML text display sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20text%20display%20sample)
