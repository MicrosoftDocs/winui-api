---
-api-id: T:Microsoft.UI.Xaml.Controls.ProgressRingTemplateSettings
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.ProgressRingTemplateSettings

<!--
public sealed class ProgressRingTemplateSettings : Windows.UI.Xaml.DependencyObject
-->

## -description

Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a [ProgressRing](progressring.md) control. Not intended for general use.

## -remarks

Get instances of ProgressRingTemplateSettings by querying the value of [ProgressRing.TemplateSettings](progressring_templatesettings.md).

The values from ProgressRingTemplateSettings are typically used as either the "To" or "From" values of theme animations or transitions.

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
   <controls:ProgressRing IsActive="{x:Bind ProgressToggle.IsOn, Mode=OneWay}" />
   <ToggleSwitch x:Name="ProgressToggle" Header="Toggle work" OffContent="Do work" OnContent="Working" IsOn="True" />
</StackPanel>

```
