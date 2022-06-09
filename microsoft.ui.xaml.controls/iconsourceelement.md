---
-api-id: T:Microsoft.UI.Xaml.Controls.IconSourceElement
-api-type: winrt class
---

<!-- Class syntax.
public class IconSourceElement : IconElement, IconElement
-->

# Microsoft.UI.Xaml.Controls.IconSourceElement

## -description

Represents an icon that uses an IconSource as its content.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks

[IconSource](iconsource.md) is similar to [IconElement](iconelement.md). However, because it is not a [FrameworkElement](/windows/winui/api/microsoft.ui.xaml.frameworkelement), it can be shared.

`IconSourceElement` provides a wrapper that lets you use an `IconSource` in places that require an `IconElement`. For example, the [AppBarButton.Icon](appbarbutton_icon.md) property takes an `IconElement`. You can use an `IconSource` derived class as the icon like this:

```xaml
<AppBarButton Label="Accept">
    <AppBarButton.Icon>
        <IconSourceElement>
            <IconSourceElement.IconSource>
                <SymbolIconSource Symbol="Accept"/>
            </IconSourceElement.IconSource>
        </IconSourceElement>
    </AppBarButton.Icon>
</AppBarButton>
```

## -see-also

## -examples

