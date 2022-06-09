---
-api-id: P:Microsoft.UI.Xaml.Controls.AppBarButton.DynamicOverflowOrder
-api-type: winrt property
---

<!-- Property syntax
public int DynamicOverflowOrder { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.AppBarButton.DynamicOverflowOrder

## -description
Gets or sets the order in which this item is moved to the [CommandBar](commandbar.md) overflow menu.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<AppBarButton DynamicOverflowOrder="int" .../>
```


## -property-value
The order in which this item is moved to the overflow menu relative to other items.

## -remarks
For more info and guidelines, see the [App bar and command bar](/windows/uwp/controls-and-patterns/app-bars) article.

Starting in Windows 10, version 1607, [CommandBar](commandbar.md) introduces a dynamic overflow feature. By default, [PrimaryCommands](commandbar_primarycommands.md) automatically move in or out of the overflow area as the command bar width changes, for example, when users resize their app window. You can set the [IsDynamicOverflowEnabled](commandbar_isdynamicoverflowenabled.md) property to **false** to disable this behavior.

Dynamic overflow affects only the UI presentation of the commands, it doesn’t move commands from the [PrimaryCommands](commandbar_primarycommands.md) collection to [SecondaryCommands](commandbar_secondarycommands.md).

This property has an effect only when this element is in the [CommandBar.PrimaryCommands](commandbar_primarycommands.md) collection and [CommandBar.IsDynamicOverflowEnabled](commandbar_isdynamicoverflowenabled.md) is **true**.

You can assign the same DynamicOverflowOrder value to more than one element. Elements with the same value move in and out of the overflow area at the same time.

### Version compatibility

The DynamicOverflowOrder property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

> [!NOTE]
> Dynamic overflow is available when your app is compiled for Windows 10, version 1607 and running on version 1607 (or later). Dynamic overflow is not available when your app is compiled for a previous version or is running on a previous version.

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](/uwp/api/windows.foundation.metadata.apiinformation) class to check for the presence of this property before you set it.

```xaml
<CommandBar x:Name="commandBar1" Loaded="CommandBar_Loaded">
    <AppBarButton x:Name="appBarButtonCut" Icon="Cut" Label="Cut"/>
    <AppBarButton x:Name="appBarButtonCopy" Icon="Copy" Label="Copy"/>
    <AppBarSeparator x:Name="appBarSeparator1"/>
    <AppBarButton x:Name="appBarButtonPaste" Icon="Paste" Label="Paste"/>
</CommandBar>
```

```csharp
private void CommandBar_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.AppBarButton", "DynamicOverflowOrder"))
    {
        commandBar1.IsDynamicOverflowEnabled = true;
        appBarButtonCut.DynamicOverflowOrder = 1;
        appBarButtonCopy.DynamicOverflowOrder = 2;
        appBarSeparator1.DynamicOverflowOrder = 2;
        appBarButtonPaste.DynamicOverflowOrder = 3;
    }
}

```



## -examples

## -see-also
