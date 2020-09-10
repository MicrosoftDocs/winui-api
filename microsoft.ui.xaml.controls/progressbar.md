---
-api-id: T:Microsoft.UI.Xaml.Controls.ProgressBar
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.ProgressBar

<!--
public class ProgressBar : Windows.UI.Xaml.Controls.Primitives.RangeBase
-->

## -description

Represents a control that indicates the progress of an operation.

## -remarks

A ProgressBar control visually indicates progress of an operation with one of two styles: a bar that displays a repeating pattern, or a bar that fills based on a value.

<img src="images/controls/progress-bar-two-states.gif" alt="Indeterminate and determinate progress bar controls" />

The [IsIndeterminate](progressbar_isindeterminate.md) property determines the appearance of a ProgressBar.

- Set [IsIndeterminate](progressbar_isindeterminate.md) to **true** to display a repeating pattern. An alternative control to use for indeterminate progress is a [ProgressRing](/uwp/api/windows.ui.xaml.controls.progressring).
- Set [IsIndeterminate](progressbar_isindeterminate.md) to **false** to fill the bar based on a value. (This is the default.) When [IsIndeterminate](progressbar_isindeterminate.md) is **false**, you specify the range with the [Minimum](/uwp/api/windows.ui.xaml.controls.primitives.rangebase.minimum) and [Maximum](/uwp/api/windows.ui.xaml.controls.primitives.rangebase.maximum) properties. By default **Minimum** is 0 and **Maximum** is 100. To specify the progress value, you set the [Value](/uwp/api/windows.ui.xaml.controls.primitives.rangebase.value) property.

## -see-also

[ProgressRing](/uwp/api/windows.ui.xaml.controls.progressring), [Progress controls](/windows/uwp/controls-and-patterns/progress-controls)

## -examples

The following shows how to set up an indeterminate ProgressBar and a basic determinate ProgressBar where the value is dependent on a RepeatButton click.

```xaml
<!-- xmlns:muxc="using:Microsoft.UI.Xaml.Controls" -->

<StackPanel x:Name="LayoutRoot">
    <StackPanel BorderThickness="4" BorderBrush="Black" Padding="12">
        <TextBlock Text="Indeterminate Progress Bar"/>
        <muxc:ProgressBar IsIndeterminate="True" Margin="0,12"/>
    </StackPanel>
    <StackPanel BorderBrush="Black" BorderThickness="4" Padding="12">
        <TextBlock Text="Value-Based Progress Bar"/>
        <muxc:ProgressBar x:Name="progressBar1" Value="0" Maximum="200" Margin="0,12"/>
        <RepeatButton Content="Press and hold" Click="RepeatButton_Click"/>
    </StackPanel>
</StackPanel>
```

```csharp
private static int _clicks = 0;

private void RepeatButton_Click(object sender, RoutedEventArgs e)
{
    _clicks += 1;
    progressBar1.Value = _clicks;
    if (_clicks >= progressBar1.Maximum) _clicks = 0;
}
```

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, see the [ProgressBar](xamlcontrolsgallery:/item/ProgressBar) in action.

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).
