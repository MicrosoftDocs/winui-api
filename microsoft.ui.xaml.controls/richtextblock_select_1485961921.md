---
-api-id: M:Microsoft.UI.Xaml.Controls.RichTextBlock.Select(Microsoft.UI.Xaml.Documents.TextPointer,Microsoft.UI.Xaml.Documents.TextPointer)
-api-type: winrt method
---

<!-- Method syntax
public void Select(Windows.UI.Xaml.Documents.TextPointer start, Windows.UI.Xaml.Documents.TextPointer end)
-->

# Microsoft.UI.Xaml.Controls.RichTextBlock.Select

## -description
Selects a range of text in the [RichTextBlock](richtextblock.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param start
An object that represents the start of the range to select.

### -param end
An object that represents the end of the range to select.

## -remarks
In Windows Presentation Foundation (WPF) and Microsoft Silverlight the equivalent API uses integer for start and end positions. This implementation uses [TextPointer](../microsoft.ui.xaml.documents/textpointer.md) objects to specify the selection.

## -examples

## -see-also
