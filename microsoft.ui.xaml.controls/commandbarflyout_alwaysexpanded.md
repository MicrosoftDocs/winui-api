---
-api-id: P:Microsoft.UI.Xaml.Controls.CommandBarFlyout.AlwaysExpanded
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.CommandBarFlyout.AlwaysExpanded

<!--
public bool AlwaysExpanded { get; set; }
-->


## -description
Gets or sets a value that indicates whether or not the CommandBarFlyout should always stay in its Expanded state and block the user from entering the Collapsed state. Defaults to false.

## -property-value

## -remarks
When this property is set to true, the "see more" button will not appear on the CommandBarFlyout, and the user will not be able to collapse the CommandBarFlyout. While the "see more" button is not visible, other AppBarButtons/CommandBarFlyout items are able to take its space.

The CommandBarFlyout still has normal closing behavior when this property is set (when the user clicks a secondary command or clicks outside of the flyout, the flyout will close).



## -see-also

## -examples
In the following example, the CommandBarFlyout will open in its expanded state and the user will not be able to send it to its collapsed state. 

```xml
<CommandBarFlyout x:Key="Flyout1" AlwaysExpanded="true">
    <AppBarButton Label="Share" Icon="Share" Click="OnElementClicked" />
    <AppBarButton Label="Save" Icon="Save" Click="OnElementClicked" />
    <CommandBarFlyout.SecondaryCommands>
        <AppBarButton x:Name="ResizeButton1" Label="Resize" Click="OnElementClicked" />
        <AppBarButton x:Name="MoveButton1" Label="Move" Click="OnElementClicked" />
    </CommandBarFlyout.SecondaryCommands>
</CommandBarFlyout>
```

