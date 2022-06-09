---
-api-id: P:Microsoft.UI.Xaml.Controls.FlyoutPresenter.IsDefaultShadowEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsDefaultShadowEnabled { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.FlyoutPresenter.IsDefaultShadowEnabled

## -description

Gets or sets a value that indicates whether the default shadow effect is shown.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

**true** if the default shadow effect is shown; otherwise, **false**. The default is **true**.

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Z-depth and shadow](/windows/apps/design/layout/depth-shadow).

Many common controls automatically cast shadows using a [ThemeShadow](../microsoft.ui.xaml.media/themeshadow.md). 

If the default shadow doesn't look correct on your Flyout's content then you can disable it by setting this property to `false`.

## -see-also

## -examples

