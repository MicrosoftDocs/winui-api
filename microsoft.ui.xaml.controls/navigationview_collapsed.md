---
-api-id: E:Microsoft.UI.Xaml.Controls.NavigationView.Collapsed
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.NavigationView.Collapsed

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.NavigationView,Microsoft.UI.Xaml.Controls.NavigationViewCollapsedEventArgs> Collapsed;
-->

## -description

Occurs when a node in the tree is collapsed.

## -remarks

Analogous to [TreeView.Collapse](https://docs.microsoft.com/windows/winui/api/microsoft.UI.Xaml.Controls.TreeView.Collapse)

## -see-also

## -examples

The following example creates a hierarchical NavigationView and sets up an event handler for the Collapsed event called OnItemCollapsed. In this event handler, the last collapsed item's Content property is set to display in the CollapsedItemLabel TextBlock.

```xaml
<muxc:NavigationView x:Name="navview" 
    MenuItemsSource="{x:Bind categories, Mode=OneWay}" 
    Expanding="OnItemExpanding" 
    Collapsed="OnItemCollapsed" 
    PaneDisplayMode="Left">
    
    <StackPanel Margin="10,10,0,0">
        <TextBlock Margin="0,10,0,0" x:Name="ExpandingItemLabel" Text="Last Expanding: N/A"/>
        <TextBlock x:Name="CollapsedItemLabel" Text="Last Collapsed: N/A"/>
    </StackPanel>    
</muxc:NavigationView>
```

```csharp
private void OnItemCollapsed(object sender, NavigationViewItemCollapsedEventArgs e)
{
    var nvib = e.CollapsedItemContainer;
    var name = "Last Collapsed: " + nvib.Content;
    CollapsedItemLabel.Text = name;
}
```
## -xaml-syntax

```xaml
<NavigationView Collapsed="eventhandler" />
```


