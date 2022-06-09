---
-api-id: P:Microsoft.UI.Xaml.Controls.AppBarButton.KeyboardAcceleratorTextOverride
-api-type: winrt property
---

<!-- Property syntax.
public string KeyboardAcceleratorTextOverride { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.AppBarButton.KeyboardAcceleratorTextOverride

## -description
Gets or sets a string that overrides the default key combination string associated with a [keyboard accelerator](../microsoft.ui.xaml/uielement_keyboardaccelerators.md).

![Example of a menu showing keyboard accelerators for various menu items](images/keyboard-accelerators.png)  
*Example of a menu showing keyboard accelerators for various menu items*

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
The string to replace the default key combination string. The default is null.

Use a single space for no text.

## -remarks
Windows 10, version 1703, introduced [keyboard accelerator](../microsoft.ui.xaml/uielement_keyboardaccelerators.md) shortcuts. However, these shortcuts were not displayed with the UI of their corresponding controls.

Starting with Windows 10, version 1803, when [KeyboardAccelerators](../microsoft.ui.xaml/uielement_keyboardaccelerators.md) are declared, controls display the corresponding key combinations by default.

The override text is not be presented if the system cannot detect an attached keyboard (you can check this yourself through the [KeyboardPresent](/uwp/api/windows.devices.input.keyboardcapabilities.keyboardpresent) property).

### Version compatibility

The KeyboardAcceleratorTextOverride property is not available prior to Windows 10, version 1803. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](/uwp/api/windows.foundation.metadata.apiinformation) class to check for the presence of this property before you set it.

```xaml
<CommandBar x:Name="commandBar1" Loaded="CommandBar_Loaded">
    <AppBarButton x:Name="appBarButtonCut" Icon="Cut" Label="Cut"/>
</CommandBar>
```

```csharp
private void CommandBar_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.AppBarButton", "KeyboardAcceleratorTextOverride"))
    {
        appBarButtonCut.KeyboardAcceleratorTextOverride = "Ctrl+C";
    }
}

```

## -see-also
[Keyboard Accelerators](/windows/apps/design/input/keyboard-accelerators)

## -examples

