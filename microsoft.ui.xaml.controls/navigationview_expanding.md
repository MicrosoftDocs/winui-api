---
-api-id: E:Microsoft.UI.Xaml.Controls.NavigationView.Expanding
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.NavigationView.Expanding

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.NavigationView,Microsoft.UI.Xaml.Controls.NavigationViewExpandingEventArgs> Expanding;
-->

## -description

Occurs when a node in the tree starts to expand.

## -remarks

In order to fill in nodes as they're expanding, set the HasUnrealizedChildren property to true, and then add the children during this Expanding event. See the TreeView example [fill a node when it's expanding](https://docs.microsoft.com/windows/apps/design/controls/tree-view#fill-a-node-when-its-expanding).

Analogous to [TreeView.Expanding](https://docs.microsoft.com/windows/winui/api/microsoft.UI.Xaml.Controls.TreeView.Expanding) event.

## -see-also

## -examples

The following example creates a hierarchical NavigationView and sets up an event handler for the Expanding event called OnItemExpanding. In this event handler, the expanded item's Content property is set to display in the ExpandingItemLabel TextBlock.

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
private void OnItemExpanding(object sender, NavigationViewItemExpandingEventArgs e)
{
    var nvib = e.ExpandingItemContainer;
    var name = "Last Expanding: " + nvib.Content.ToString();
    ExpandingItemLabel.Text = name;
}
```

## -xaml-syntax

```xaml
<NavigationView Expanding="eventhandler" />
```
