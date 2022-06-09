---
-api-id: P:Microsoft.UI.Xaml.Controls.ItemsControl.ItemsPanel
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ItemsPanelTemplate ItemsPanel { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ItemsControl.ItemsPanel

## -description
Gets or sets the template that defines the panel that controls the layout of items.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<itemsControl>
  <itemsControl.ItemsPanel>
    singlePanelTemplate
  </itemsControl.ItemsPanel>
</itemsControl>
- or -
<itemsControl ItemsPanel="resourceReferenceToPanelTemplate"/>
```


## -xaml-values
<dl><dt>singlePanelTemplate</dt><dd>singlePanelTemplateA single ItemsPanelTemplate object element. That ItemsPanelTemplate would typically have multiple child elements that define the panel layout.</dd>
<dt>resourceReferenceToPanelTemplate</dt><dd>resourceReferenceToPanelTemplateA resource reference to an existing ItemsPanelTemplate from a resources collection. The resource reference must specify the desired ItemsPanelTemplate by key.</dd>
</dl>
## -property-value
An [ItemsPanelTemplate](itemspaneltemplate.md) that defines the panel to use for the layout of the items. The default value for the [ItemsControl](itemscontrol.md) is an [ItemsPanelTemplate](itemspaneltemplate.md) that specifies a [StackPanel](stackpanel.md).

## -remarks
> [!NOTE]
> [ComboBox](combobox.md) uses a [CarouselPanel](../microsoft.ui.xaml.controls.primitives/carouselpanel.md) as its ItemsPanel. Using a different panel as the ItemsPanel of [ComboBox](combobox.md) is not supported and might result in undesired behavior.

## -examples

Replace the default panel used in a ListView with an [ItemsStackPanel](/uwp/api/Windows.UI.Xaml.Controls.ItemsStackPanel) that has its Orientation changed to Horizontal.

```xaml
<ListView>
    <x:String>Hello</x:String>
    <x:String>World</x:String>

    <ItemsControl.ItemsPanel>
        <ItemsPanelTemplate>
            <ItemsStackPanel Orientation="Horizontal" />
        </ItemsPanelTemplate>
    </ItemsControl.ItemsPanel>
</ListView>
```

## -see-also
