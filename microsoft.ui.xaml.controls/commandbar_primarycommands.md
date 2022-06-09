---
-api-id: P:Microsoft.UI.Xaml.Controls.CommandBar.PrimaryCommands
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IObservableVector<Windows.UI.Xaml.Controls.ICommandBarElement> PrimaryCommands { get; }
-->

# Microsoft.UI.Xaml.Controls.CommandBar.PrimaryCommands

## -description
Gets the collection of primary command elements for the [CommandBar](commandbar.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<CommandBar>
    <CommandBar.PrimaryCommands>
      commandBarElements
    </CommandBar.PrimaryCommands>
</CommandBar>
```


## -xaml-values
<dl><dt>commandBarElements</dt><dd>commandBarElementsOne or more object elements for classes that implement ICommandBarElement. These are typically AppBarButton, AppBarToggleButton or AppBarSeparator elements.</dd>
</dl>
## -property-value
The collection of primary command elements for the [CommandBar](commandbar.md). The default is an empty collection.

## -remarks
The PrimaryCommands collection can contain only [AppBarButton](appbarbutton.md), [AppBarToggleButton](appbartogglebutton.md), or [AppBarSeparator](appbarseparator.md) command elements. The primary commands are shown on the right side of the [CommandBar](commandbar.md), to the left of the More button (...) when the [FlowDirection](../microsoft.ui.xaml/frameworkelement_flowdirection.md) is **LeftToRight**. The layout is reversed when the [FlowDirection](../microsoft.ui.xaml/frameworkelement_flowdirection.md) is **RightToLeft**.

## -examples

## -see-also
[SecondaryCommands](commandbar_secondarycommands.md)
