---
-api-id: M:Microsoft.UI.Xaml.DataTemplate.LoadContent
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.DependencyObject LoadContent()
-->

# Microsoft.UI.Xaml.DataTemplate.LoadContent

## -description
Creates the [UIElement](uielement.md) objects in the [DataTemplate](datatemplate.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
The root [UIElement](uielement.md) of the [DataTemplate](datatemplate.md).

## -remarks
When you call LoadContent, the [UIElement](uielement.md) objects in the [DataTemplate](datatemplate.md) are created, and you can add them to the visual tree of another [UIElement](uielement.md).

## -examples
The following examples demonstrate using the LoadContent method to change the appearance of a [Border](../microsoft.ui.xaml.controls/border.md) at run time. The example creates a [ListBox](../microsoft.ui.xaml.controls/listbox.md) that contains the numbers 1 through 10. When the user selects an item in the [ListBox](../microsoft.ui.xaml.controls/listbox.md), the [Border](../microsoft.ui.xaml.controls/border.md) displays the selected number. If the user selects an even number, the number is red and has a green circle around it. If the user selects an odd number, the number is blue and has a purple square around it.




[!code-xaml[Snippet1_XAML](../microsoft.ui.xaml.controls.primitives/code/DataTemplateSelectionSnippets/csharp/Page.xaml#Snippet1_XAML)]


[!code-csharp[Snippet2_CS](../microsoft.ui.xaml.controls.primitives/code/DataTemplateSelectionSnippets/csharp/Page.xaml.cs#Snippet2_CS)]


[!code-vb[Snippet2_VB](../microsoft.ui.xaml.controls.primitives/code/DataTemplateSelectionSnippets/vbnet/Page.xaml.vb#Snippet2_VB)]

## -see-also
