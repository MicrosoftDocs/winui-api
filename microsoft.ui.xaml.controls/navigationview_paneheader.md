---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationView.PaneHeader
-api-type: winrt property
---
<!-- Property syntax.
public UIElement PaneHeader { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.NavigationView.PaneHeader


## -description

Gets or sets the content for the pane header.


**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

The content of the pane header. The default is **null**.


## -remarks

The PaneHeader property takes a single UIElement, which can be a layout panel that contains additional elements.


## -see-also


## -examples


## -xaml-syntax

```xaml
<NavigationView>
  <NavigationView.PaneHeader>
    headerElement
  </NavigationView.PaneHeader>
</NavigationView>
```


## -xaml-values

<dt>headerElement</dt><dd>headerElementA single UI element that serves as header content. This can be a panel that contains other UI elements.</dd>
</dl>


