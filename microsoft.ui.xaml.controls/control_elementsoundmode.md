---
-api-id: P:Microsoft.UI.Xaml.Controls.Control.ElementSoundMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.ElementSoundMode ElementSoundMode { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Control.ElementSoundMode

## -description
Get or sets a value that specifies a control's preference for whether sounds are played.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<control ElementSoundMode="elementSoundModeMemberName"/>
```


## -xaml-values
<dl><dt>elementSoundModeMemberName</dt><dd>elementSoundModeMemberNameA named constant of the ElementSoundMode enumeration, such as On.</dd>
</dl>
## -property-value
A value of the enumeration that specifies a control's preference for whether sounds are played. The default is **Auto**.

## -remarks
Set the ElementSoundMode property to override the global [ElementSoundPlayer](../microsoft.ui.xaml/elementsoundplayer.md) setting for a specific control.

For more info about using this property, see [Sound in UWP apps](/windows/uwp/style/sound).

### Version compatibility

The ElementSoundMode property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](/uwp/api/windows.foundation.metadata.apiinformation) class to check for the presence of this property before you set it.

```csharp
 private void MainPage_Loaded(object sender, RoutedEventArgs e)
 {
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.Control", "ElementSoundMode"))
    {
        button1.ElementSoundMode = ElementSoundMode.Off;
    }
}

```



## -examples

## -see-also
[ElementSoundPlayer](../microsoft.ui.xaml/elementsoundplayer.md), [Sound in UWP apps](/windows/uwp/style/sound)
