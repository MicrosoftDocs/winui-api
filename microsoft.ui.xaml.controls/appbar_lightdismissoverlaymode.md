---
-api-id: P:Microsoft.UI.Xaml.Controls.AppBar.LightDismissOverlayMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.LightDismissOverlayMode LightDismissOverlayMode { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.AppBar.LightDismissOverlayMode

## -description
Gets or sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<appBar LightDismissOverlayMode="lightDismissOverlayModeMemberName" />
```


## -xaml-values
<dl><dt>lightDismissOverlayModeMemberName</dt><dd>lightDismissOverlayModeMemberNameA named constant of the LightDismissOverlayMode enumeration; for example, On or Off.</dd>
</dl>
## -property-value
A value of the enumeration that specifies whether the area outside of a light-dismiss UI is darkened. The default is **Auto**.

## -remarks
Transient UI, such as a [MenuFlyout](menuflyout.md) or secondary menu in a command bar, closes when you click or tap outside of it. This is called light-dismiss. "Overlay" refers to the area outside of a light-dismiss UI.

By default, the "overlay" is darkened on the Xbox, and not darkened on other devices families. You can set LightDismissOverlayMode to **On** to make your app darken the "overlay" area on all device families, or set it to **Off** to not darken the "overlay" area on all device families.

### Version compatibility

The LightDismissOverlayMode property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](/uwp/api/windows.foundation.metadata.apiinformation) class to check for the presence of this property before you set it.

```xaml
<CommandBar x:Name="commandBar1" Loaded="CommandBar_Loaded"/>
```

```csharp
private void CommandBar_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.AppBar", "LightDismissOverlayMode"))
    {
        commandBar1.LightDismissOverlayMode = LightDismissOverlayMode.On;
    }
}

```



## -examples

## -see-also
