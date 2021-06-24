---
-api-id: P:Microsoft.UI.Xaml.Controls.RadioButtons.ItemsSource
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.RadioButtons.ItemsSource

<!--
public object ItemsSource { get; set; }
-->

## -description

Gets or sets an object source used to generate the content of the control.

## -property-value

The object that is used to generate the content of the control. The default is `null`.

## -remarks

> For more info, design guidance, and code examples, see [Radio buttons](/windows/apps/design/controls/radio-button).

For more info about the behavior of the ItemsSource property, see [ItemsControl.ItemsSource](/uwp/api/windows.ui.xaml.controls.itemscontrol.itemssource).

## -see-also

[RadioButtons](radiobuttons.md), [Items](radiobuttons_items.md), [ItemsControl.ItemsSource](/uwp/api/windows.ui.xaml.controls.itemscontrol.itemssource)

## -examples

This example shows how you can bind the control to a custom data source.

```xaml
<!-- xmlns:muxc="using:Microsoft.UI.Xaml.Controls -->
 <muxc:RadioButtons Header="Background color"
                    SelectionChanged="BackgroundColor_SelectionChanged"
                    ItemsSource="{x:Bind colorOptionItems}"/>

...

<Border x:Name="ExampleBorder" Width="100" Height="100"/>
```

```c#
public sealed partial class MainPage : Page
{
    // Custom data item.
    public class ColorOptionDataModel
    {
        public string Label { get; set; }
        public SolidColorBrush ColorBrush { get; set; }

        public override string ToString()
        {
            return Label;
        }
    }

    List<ColorOptionDataModel> colorOptionItems;

    public MainPage1()
    {
        this.InitializeComponent();

        colorOptionItems = new List<ColorOptionDataModel>();
        colorOptionItems.Add(new ColorOptionDataModel()
            { Label = "Red", ColorBrush = new SolidColorBrush(Colors.Red) });
        colorOptionItems.Add(new ColorOptionDataModel()
            { Label = "Green", ColorBrush = new SolidColorBrush(Colors.Green) });
        colorOptionItems.Add(new ColorOptionDataModel()
            { Label = "Blue", ColorBrush = new SolidColorBrush(Colors.Blue) });
    }

    private void BackgroundColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var option = e.AddedItems[0] as ColorOptionDataModel;
        ExampleBorder.Background = option?.ColorBrush;
    }
}
```
