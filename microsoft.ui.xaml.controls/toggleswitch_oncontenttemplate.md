---
-api-id: P:Microsoft.UI.Xaml.Controls.ToggleSwitch.OnContentTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate OnContentTemplate { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ToggleSwitch.OnContentTemplate

## -description
Gets or sets the [DataTemplate](../microsoft.ui.xaml/datatemplate.md) used to display the control's content while in "On" state.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<ToggleSwitch>
  <ToggleSwitch.OnContentTemplate>
    singleDataTemplate
  </ToggleSwitch.OnContentTemplate>
</ToggleSwitch>
- or -
<ToggleSwitch OnContentTemplate="resourceReferenceToDataTemplate"/>
```


## -xaml-values
<dl><dt>singleDataTemplate</dt><dd>singleDataTemplateA single DataTemplate object element. That DataTemplate would typically have multiple child elements that define the visual appearance of the data representation.</dd>
<dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key.</dd>
</dl>
## -property-value
The [DataTemplate](../microsoft.ui.xaml/datatemplate.md) that displays the control's content while in "On" state.

## -remarks

## -examples

## -see-also
