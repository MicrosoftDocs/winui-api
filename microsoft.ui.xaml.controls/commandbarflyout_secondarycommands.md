---
-api-id: P:Microsoft.UI.Xaml.Controls.CommandBarFlyout.SecondaryCommands
-api-type: winrt property
---
<!-- Property syntax.
public IObservableVector<ICommandBarElement> SecondaryCommands { get; }
-->

# Microsoft.UI.Xaml.Controls.CommandBarFlyout.SecondaryCommands



## -description

Gets the collection of secondary command elements for the [CommandBarFlyout](commandbarflyout.md).



**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

The collection of secondary command elements for the [CommandBarFlyout](commandbarflyout.md). The default is an empty collection.



## -remarks
The SecondaryCommands collection can directly contain only [AppBarButton](/uwp/api/windows.ui.xaml.controls.appbarbutton), [AppBarToggleButton](/uwp/api/windows.ui.xaml.controls.appbartogglebutton), or [AppBarSeparator](/uwp/api/windows.ui.xaml.controls.appbarseparator) command elements.  Other elements must be wrapped in an [AppBarElementContainer](/uwp/api/windows.ui.xaml.controls.appbarelementcontainer).

The secondary commands are shown in the menu portion of the flyout when the [CommandBarFlyout](commandbarflyout.md) is expanded.



## -see-also

[PrimaryCommands](commandbarflyout_primarycommands.md)



## -examples



## -xaml-syntax

```xaml
<CommandBarFlyout>
    <CommandBarFlyout.SecondaryCommands>
       commandBarElements
    </CommandBarFlyout.SecondaryCommands>
</CommandBarFlyout>
```



## -xaml-values

<dl><dt>commandBarElements</dt><dd>commandBarElementsOne or more object elements for classes that implement ICommandBarElement. These are typically AppBarButton, AppBarToggleButton or AppBarSeparator elements.</dd>
</dl>



