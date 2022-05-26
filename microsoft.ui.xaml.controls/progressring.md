---
-api-id: T:Microsoft.UI.Xaml.Controls.ProgressRing
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.ProgressRing

<!--
public class ProgressRing : Windows.UI.Xaml.Controls.Control
-->

## -description

Represents a control that indicates the progress of an operation. The typical visual appearance is a ring-shaped "spinner".

## -remarks

ProgressRing is a control that visually indicates progress of an operation with one of two styles: a ring that repeatedly animates, or a ring that fills based on a value.

<img src="images/controls/ProgressRing_Indeterminate.gif" alt="Indeterminate progress ring control"/>
<img src="images/controls/ProgressRing_Determinate.gif" alt="Determinate progress ring control"/>

Use a ProgressRing to visually indicate that an operation is in progress. Set the [IsActive](progressring_isactive.md) property to turn the ProgressRing on or off. If  [IsActive](progressring_isactive.md) is false, the ProgressRing is not shown, but space is reserved for it in the UI layout. To not reserve space for the ProgressRing, set its [Visibility](/uwp/api/windows.ui.xaml.uielement.visibility) property to [Collapsed](/uwp/api/windows.ui.xaml.visibility).

The [IsIndeterminate](progressring_isindeterminate.md) property determines the appearence of a ProgressRing. 
- Set [IsIndeterminate](progressring_isindeterminate.md) to **true** to display a repeating animation. (This is the default)
- Set [IsIndeterminate](progressring_isindeterminate.md) to **false** to fill the bar based on a value. When [IsIndeterminate](progressring_isindeterminate.md) is **false**, you specify the range with the [Minimum](progressring_minimum.md) and [Maximum](progressring_maximum.md) properties. By default **Minimum** is 0 and **Maximum** is 100. To specify the progress value, you set the [Value](progressring_value.md) property. 

## -see-also

[Progress controls overview](/windows/uwp/controls-and-patterns/progress-controls), [ProgressBar](progressbar.md), [Controls list](/windows/apps/design/controls/), [Controls by function](/windows/apps/design/controls/controls-by-function)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Progress controls](/windows/apps/design/controls/progress-controls).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/ProgressRing) or [**WinUI 2 Gallery**](winui2gallery:/item/ProgressRing).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


This example shows how to set the [IsActive](progressring_isactive.md) property of a ProgressRing in code. A [ToggleSwitch](/uwp/api/windows.ui.xaml.controls.toggleswitch) is used to turn theProgressRing control on or off.

```xaml

<StackPanel>
   <muxc:ProgressRing IsActive="{x:Bind ProgressToggle.IsOn, Mode=OneWay}" />
   <ToggleSwitch x:Name="ProgressToggle" Header="Toggle work" OffContent="Do work" OnContent="Working" IsOn="True" />
</StackPanel>

```

This example shows how to set the [IsIndeterminate](progressring_isindeterminate.md) property in code to show a progress ring filling based on the value property. 

```xaml

<StackPanel>
   <muxc:ProgressRing IsIndeterminate="false">
   <muxc:NumberBox x:Name="ProgressValue" Minimum="0" Maximum="100" SpinButtonPlacementMode="Inline" ValueChanged="ProgressValue_ValueChanged"/>
</StackPanel>

```

```csharp
 private void ProgressValue_ValueChanged(Microsoft.UI.Xaml.Controls.NumberBox sender, Microsoft.UI.Xaml.Controls.NumberBoxValueChangedEventArgs args)
{
   if (!sender.Value.IsNaN())
   {
         ProgressRing2.Value = sender.Value;
   }
   else
   {
         sender.Value = 0;
   }
}
```
