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

This example shows how to set the [IsActive](progressring_isactive.md) property of a ProgressRing in code. A [ToggleSwitch](/uwp/api/windows.ui.xaml.controls.toggleswitch) is used to turn theProgressRing control on or off.

```xaml

<StackPanel>
   <controls:ProgressRing IsActive="{x:Bind ProgressToggle.IsOn, Mode=OneWay}" />
   <ToggleSwitch x:Name="ProgressToggle" Header="Toggle work" OffContent="Do work" OnContent="Working" IsOn="True" />
</StackPanel>

```

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, see the [ProgressRing](xamlcontrolsgallery:/item/ProgressRing) in action.

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).
