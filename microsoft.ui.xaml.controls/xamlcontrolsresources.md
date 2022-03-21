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

> [!TIP]
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:) or [**WinUI 2 Gallery**](winui2gallery:).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/p/winui-3-controls-gallery/9p3jfpwwdzrc) and the [**WinUI 2 Gallery**](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


The following snippet shows how to specify the default control styles.

```xaml
<Application>
    <Application.Resources>
        <XamlControlsResources xmlns="using:Microsoft.UI.Xaml.Controls"/>
    </Application.Resources>
</Application>
```
