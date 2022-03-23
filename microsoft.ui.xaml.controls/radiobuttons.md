---
-api-id: T:Microsoft.UI.Xaml.Controls.RadioButtons
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.RadioButtons

<!--
public class RadioButtons : Windows.UI.Xaml.Controls.Control
-->

## -description

Represents a control that shows a group of related options from which one can be selected.

## -remarks

> For more info, design guidance, and code examples, see [Radio buttons](/windows/apps/design/controls/radio-button).

![Example of a RadioButtons group, with one radio button selected](images/radiobuttons/radiobuttons-default-group.png)

Use radio buttons, also called option buttons, to let users select one option from a collection of two or more mutually exclusive, but related, options. Radio buttons are always used in groups, and each option is represented by one radio button in the group.

The `RadioButtons` control simplifies layout, handles keyboard navigation and accessibility, and supports binding to a data source. When you use RadioButtons, you can treat your group of options as a single entity, rather than keeping track of individual [RadioButton](/uwp/api/Windows.UI.Xaml.Controls.RadioButton) controls.

The `RadioButtons` control uses a content model similar to an [ItemsControl](/uwp/api/windows.ui.xaml.controls.itemscontrol). This means that you can:

- Populate it by adding items directly to the [Items](radiobuttons_items.md) collection or by binding data to its [ItemsSource](radiobuttons_itemssource.md) property.
- Use the [SelectedIndex](radiobuttons_selectedindex.md) or [SelectedItem](radiobuttons_selecteditem.md) properties to get and set which option is selected.
- Handle the [SelectionChanged](radiobuttons_selectionchanged.md) event to take action when an option is chosen.

## -see-also

[Radio buttons](/windows/apps/design/controls/radio-button)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Radio buttons](/windows/apps/design/controls/radio-button).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/RadioButtons) or [**WinUI 2 Gallery**](winui2gallery:/item/RadioButtons).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

