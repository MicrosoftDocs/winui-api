---
-api-id: T:Microsoft.UI.Xaml.Controls.ProgressRing
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.ProgressRing

<!--
public class ProgressRing : Windows.UI.Xaml.Controls.Control
-->

## -description

Represents a control that indicates that an operation is ongoing. The typical visual appearance is a ring-shaped "spinner" that cycles an animation as progress continues.

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Progress controls](/windows/uwp/controls-and-patterns/progress-controls).

ProgressRing is a control that indicates indeterminate progress by displaying an animated ring.

<img src="images/controls/ProgressRing.png"/>

Use a ProgressRing to visually indicate that an operation is in progress. Set the [IsActive](progressring_isactive.md) property to turn the ProgressRing on or off. If  [IsActive](progressring_isactive.md) is false, the ProgressRing is not shown, but space is reserved for it in the UI layout. To not reserve space for the ProgressRing, set its [Visibility](https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.uielement.visibility) property to [Collapsed](https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.visibility).

## -see-also

[Progress controls overview](/windows/uwp/controls-and-patterns/progress-controls), [ProgressBar](progressbar.md), [Controls list](/windows/uwp/design/controls-and-patterns/), [Controls by function](/windows/uwp/design/controls-and-patterns/controls-by-function)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Progress controls](/windows/uwp/controls-and-patterns/progress-controls).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the ProgressBar in action](xamlcontrolsgallery:/item/ProgressRing).
>
> - [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> - [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

This example shows how to set the [IsActive](progressring_isactive.md) property of a ProgressRing in code. A [ToggleSwitch](/uwp/api/windows.ui.xaml.controls.toggleswitch) is used to turn theProgressRing control on or off.

```xaml

<StackPanel>
   <controls:ProgressRing IsActive="{x:Bind ProgressToggle.IsOn, Mode=OneWay}" />
   <ToggleSwitch x:Name="ProgressToggle" Header="Toggle work" OffContent="Do work" OnContent="Working" IsOn="True" />
</StackPanel>

```