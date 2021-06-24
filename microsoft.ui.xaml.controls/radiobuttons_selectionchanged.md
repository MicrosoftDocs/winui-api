---
-api-id: E:Microsoft.UI.Xaml.Controls.RadioButtons.SelectionChanged
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.RadioButtons.SelectionChanged

<!--
public event Windows.UI.Xaml.Controls.SelectionChangedEventHandler SelectionChanged;
-->

## -description

Occurs when the currently selected item changes.

## -remarks

> For more info, design guidance, and code examples, see [Radio buttons](/windows/apps/design/controls/radio-button).

Handle the `SelectionChanged` event to take action when an option is chosen.

You can get the selected item from the control's [SelectItem](radiobuttons_selecteditem.md) property or from the [SelectionChangedEventArgs.AddedItems](/uwp/api/windows.ui.xaml.controls.selectionchangedeventargs.addeditems) property. If you use the event args, there will only be one selected item, at index 0, so you could get the selected item like this: `string colorName = e.AddedItems[0] as string;`.

## -see-also

[RadioButtons](radiobuttons.md)

## -examples

In this example, the `SelectionChanged` event is handled to change the background color of a [Border](/uwp/api/windows.ui.xaml.controls.border) element named "ExampleBorder".

```xaml
<!-- xmlns:muxc="using:Microsoft.UI.Xaml.Controls -->
<muxc:RadioButtons Header="Background color"
                   SelectionChanged="BackgroundColor_SelectionChanged">
    <x:String>Red</x:String>
    <x:String>Green</x:String>
    <x:String>Blue</x:String>
</muxc:RadioButtons>

...

<Border x:Name="ExampleBorder" Width="100" Height="100"/>
```

```csharp
// xmlns:muxc="using:Microsoft.UI.Xaml.Controls"
private void BackgroundColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    if (ExampleBorder != null && sender is muxc.RadioButtons rb)
    {
        string colorName = rb.SelectedItem as string;
        switch (colorName)
        {
            case "Red":
                ExampleBorder.Background = new SolidColorBrush(Colors.Red);
                break;
            case "Green":
                ExampleBorder.Background = new SolidColorBrush(Colors.Green);
                break;
            case "Blue":
                ExampleBorder.Background = new SolidColorBrush(Colors.Blue);
                break;
        }
    }
}
```
