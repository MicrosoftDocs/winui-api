---
-api-id: T:Microsoft.UI.Xaml.Controls.XamlControlsResources
-api-type: winrt class
---

<!-- Class syntax.
public class XamlControlsResources : ResourceDictionary, ResourceDictionary
-->

# Microsoft.UI.Xaml.Controls.XamlControlsResources

## -description

Default styles for the controls in the [WinUI library](https://docs.microsoft.com/uwp/toolkits/winui/).

## -remarks

## -see-also

[Getting started with the Windows UI Library](https://docs.microsoft.com/uwp/toolkits/winui/getting-started)

## -examples

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, [open the app to see the controls in action](xamlcontrolsgallery:).

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).

The following snippet shows how to specify the default control styles.

```xaml
<Application>
    <Application.Resources>
        <XamlControlsResources xmlns="using:Microsoft.UI.Xaml.Controls"/>
    </Application.Resources>
</Application>
```
