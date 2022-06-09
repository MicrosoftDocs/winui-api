---
-api-id: P:Microsoft.UI.Xaml.Controls.CommandBar.SecondaryCommands
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IObservableVector<Windows.UI.Xaml.Controls.ICommandBarElement> SecondaryCommands { get; }
-->

# Microsoft.UI.Xaml.Controls.CommandBar.SecondaryCommands

## -description
Gets the collection of secondary command elements for the [CommandBar](commandbar.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<CommandBar>
    <CommandBar.SecondaryCommands>
       commandBarElements
    </CommandBar.SecondaryCommands>
</CommandBar>
```


## -xaml-values
<dl><dt>commandBarElements</dt><dd>commandBarElementsOne or more object elements for classes that implement ICommandBarElement. These are typically AppBarButton, AppBarToggleButton or AppBarSeparator elements.</dd>
</dl>
## -property-value
The collection of secondary command elements for the [CommandBar](commandbar.md). The default is an empty collection.

## -remarks
The SecondaryCommands collection can contain only [AppBarButton](appbarbutton.md), [AppBarToggleButton](appbartogglebutton.md), or [AppBarSeparator](appbarseparator.md) command elements. The secondary commands are shown in the overflow menu when the [CommandBar](commandbar.md) is open.

## -examples

## -see-also
[PrimaryCommands](commandbar_primarycommands.md)
