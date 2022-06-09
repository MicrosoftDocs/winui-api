---
-api-id: E:Microsoft.UI.Xaml.Controls.AutoSuggestBox.SuggestionChosen
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SuggestionChosen<Windows.UI.Xaml.Controls.AutoSuggestBox,  Windows.UI.Xaml.Controls.AutoSuggestBoxSuggestionChosenEventArgs>
-->

# Microsoft.UI.Xaml.Controls.AutoSuggestBox.SuggestionChosen

## -description
Raised before the text content of the editable control component is updated.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<AutoSuggestBox SuggestionChosen="eventhandler"/>
```


## -remarks
Respond to this event when you want to display information in the editable part of the control. An alternative way of updating the text when a suggestion is chosen is to use the [TextMemberPath](autosuggestbox_textmemberpath.md) property.

## -examples
When a book is chosen from a suggestion list, set the text area of `AutoSuggestBox` to the book's title:

```xaml
<AutoSuggestBox  
    ItemsSource="{x:Bind Books}"
    SuggestionChosen="AutoSuggestBox_SuggestionChosen" 
    UpdateTextOnSelect="True" />
```

```cs
private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
{
    var book = args.SelectedItem as Book;
    sender.Text = book.Title;
}
```

## -see-also
[AutoSuggestBox](autosuggestbox.md)
