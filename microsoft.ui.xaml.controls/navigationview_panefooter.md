---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationView.PaneFooter
-api-type: winrt property
---
<!-- Property syntax.
public UIElement PaneFooter { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.NavigationView.PaneFooter


## -description

Gets or sets the content for the pane footer.


**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

The content of the pane footer. The default is **null**.


## -remarks

The PaneFooter property takes a single UIElement, which can be a layout panel that contains additional elements.

You can place any content into the PaneFooter, but you should not put NavigationViewItems into it, because they will not participate in the 
selection model for the NavigationView - clicking on them will not raise the
[NavigationView.SelectionChanged](https://docs.microsoft.com/uwp/api/Microsoft.UI.Xaml.Controls.NavigationView.SelectionChanged) event.

If you place a [NavigationViewItem](navigationviewitem.md) in the PaneFooter, it will not raise the [NavigationView.ItemInvoked](navigationview_iteminvoked.md) event. The ItemInvoked event is raised only when the NavigationViewItem is in the [NavigationView.MenuItems](navigationview_menuitems.md) or the [NavigationView.FooterMenuItems](navigationview_footermenuitems.md) collection.

The PaneFooter is placed at the end of the navigation pane, but before  FooterMenuItems.

## -see-also


## -examples


## -xaml-syntax

```xaml
<NavigationView>
  <NavigationView.PaneFooter>
    footerElement
  </NavigationView.PaneFooter>
</NavigationView>
```


## -xaml-values

<dt>footerElement</dt><dd>footerElementA single UI element that serves as footer content. This can be a panel that contains other UI elements.</dd>
</dl>


