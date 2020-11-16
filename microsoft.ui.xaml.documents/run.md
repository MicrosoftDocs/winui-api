---
-api-id: T:Microsoft.UI.Xaml.Documents.Run
-api-type: winrt class
---

<!-- Class syntax.
public class Run : Windows.UI.Xaml.Documents.Inline, Windows.UI.Xaml.Documents.IRun
-->

# Microsoft.UI.Xaml.Documents.Run

## -description
Represents a discrete section of formatted or unformatted text.

## -xaml-syntax
```xaml
<Run .../>
-or-
<Run ...>text</Run>
```


## -remarks
A Run represents a discrete section of formatted or unformatted text and can be used in a [TextBlock](../microsoft.ui.xaml.controls/textblock.md) or [RichTextBlock](../microsoft.ui.xaml.controls/richtextblock.md). You can place multiple Run elements inside of a [Span](span.md).

When you use a [TextBlock](../microsoft.ui.xaml.controls/textblock.md), set the [TextBlock.Text](../microsoft.ui.xaml.controls/textblock_text.md) property directly for best performance. You typically use the Run element only when you want to format a discrete section of text within the [TextBlock](../microsoft.ui.xaml.controls/textblock.md).


For more examples, see

+ [TextBlock](../microsoft.ui.xaml.controls/textblock.md)
+ [TextBlock control guide](/windows/uwp/controls-and-patterns/text-block)
+ [RichTextBlock](../microsoft.ui.xaml.controls/richtextblock.md)
+ [RichTextBlock control guide](/windows/uwp/controls-and-patterns/rich-text-block)


## -examples
Each example shown here renders the same result. However, setting the [Text](../microsoft.ui.xaml.controls/textblock_text.md) property directly on the [TextBlock](../microsoft.ui.xaml.controls/textblock.md) has the best performance.

```xaml

<!-- Set the TextBlock.Text property directy for best performance. -->
<TextBlock Text="This is some text."/>

<TextBlock><Run>This is some text.</Run></TextBlock>

<TextBlock><Run Text="This is some text."></Run></TextBlock>

```

```csharp

// Set the TextBlock.Text property directy for best performance.
TextBlock textblock = new TextBlock();
textblock.Text = "This is some text.";

TextBlock textblock = new TextBlock();
Run run = new Run();
run.Text = "This is some text.";
textblock.Inlines.Add(run);

```



## -see-also
[Inline](inline.md), [TextBlock](../microsoft.ui.xaml.controls/textblock.md), [RichTextBlock](../microsoft.ui.xaml.controls/richtextblock.md)
