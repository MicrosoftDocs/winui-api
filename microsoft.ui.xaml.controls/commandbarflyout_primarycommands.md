---
-api-id: P:Microsoft.UI.Xaml.Controls.CommandBarFlyout.PrimaryCommands
-api-type: winrt property
ms.custom: RS5
---
<!-- Property syntax.
public IObservableVector<ICommandBarElement> PrimaryCommands { get; }
-->

# Microsoft.UI.Xaml.Controls.CommandBarFlyout.PrimaryCommands



## -description

Gets the collection of primary command elements for the [CommandBarFlyout](commandbarflyout.md).



## -property-value

The collection of primary command elements for the [CommandBarFlyout](commandbarflyout.md). The default is an empty collection.



## -remarks

The [PrimaryCommands](commandbarflyout_primarycommands.md) collection can directly contain only [AppBarButton](/uwp/api/windows.ui.xaml.controls.appbarbutton), [AppBarToggleButton](/uwp/api/windows.ui.xaml.controls.appbartogglebutton), [AppBarSeparator](/uwp/api/windows.ui.xaml.controls.appbarseparator) command elements. Other elements must be wrapped in an [AppBarElementContainer](/uwp/api/windows.ui.xaml.controls.appbarelementcontainer).

The primary commands are shown in the command bar portion of the flyout.



## -see-also

[SecondaryCommands](commandbarflyout_secondarycommands.md)


## -examples



## -xaml-syntax

```xaml
<CommandBarFlyout>
    <CommandBarFlyout.PrimaryCommands>
      commandBarElements
    </CommandBarFlyout.PrimaryCommands>
</CommandBarFlyout>
```



## -xaml-values

<dl><dt>commandBarElements</dt><dd>commandBarElementsOne or more object elements for classes that implement ICommandBarElement. These are typically AppBarButton, AppBarToggleButton or AppBarSeparator elements.</dd>
</dl>



