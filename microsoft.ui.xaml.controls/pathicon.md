---
-api-id: T:Microsoft.UI.Xaml.Controls.PathIcon
-api-type: winrt class
---

<!-- Class syntax.
public class PathIcon : Windows.UI.Xaml.Controls.IconElement, Windows.UI.Xaml.Controls.IPathIcon
-->

# Microsoft.UI.Xaml.Controls.PathIcon

## -description

Represents an icon that uses a vector path as its content.

## -xaml-syntax

```xaml
<PathIcon .../>
```

## -remarks

> [!NOTE]
> You can set the **Foreground** property on the [AppBarButton](appbarbutton.md) or on the PathIcon. If you set the [Foreground](control_foreground.md) on the [AppBarButton](appbarbutton.md), it's applied only to the default visual state. It's not applied to the other visual states defined in the [AppBarButton](appbarbutton.md) template, like `MouseOver`. If you set the [Foreground](iconelement_foreground.md) on the PathIcon, the color is applied to all visual states.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar](/windows/uwp/controls-and-patterns/app-bars).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/AppBarButton) or [**WinUI 2 Gallery**](winui2gallery:/item/AppBarButton).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


This example shows an [AppBarButton](appbarbutton.md) with a PathIcon.

```xaml
<!-- App bar button with path icon. -->
<AppBarButton Label="PathIcon" Click="AppBarButton_Click">
    <AppBarButton.Icon>
        <PathIcon Data="F1 M 16,12 20,2L 20,16 1,16" HorizontalAlignment="Center"/>
    </AppBarButton.Icon>
</AppBarButton>
```



## -see-also
[IconElement](iconelement.md), [AppBarButton](appbarbutton.md), [Path](../microsoft.ui.xaml.shapes/path.md), [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax), [Icons for UWP apps](/windows/uwp/style/icons) 
