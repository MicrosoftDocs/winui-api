---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings.OpenPaneLength
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings.OpenPaneLength

<!--
public double OpenPaneLength { get; }
-->


## -description

Gets the `min` between [OpenPaneLength](navigationview_openpanelength.md) and the window's width.
This is the calculated value of the width of the pane when opened and fully expanded.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The `min` between [OpenPaneLength](navigationview_openpanelength.md) and the window's width. Defaults to 320.0.

## -remarks

## -see-also

## -examples

This example shows the `NavigationViewTemplateSettings.OpenPaneLength` property being used in the `ControlTemplate` for `NavigationView`
to pass through to the
[Windows.UI.Xaml.Controls.SplitView.OpenPaneLength](/uwp/api/Windows.UI.Xaml.Controls.SplitView.OpenPaneLength).

```xml
<ControlTemplate TargetType="NavigationView">
    <!-- ... -->
    <SplitView
        OpenPaneLength="{Binding RelativeSource={RelativeSource TemplatedParent}, Path=TemplateSettings.OpenPaneLength}"
        Background="{TemplateBinding Background}"
        BorderBrush="{ThemeResource NavigationViewItemSeparatorForeground}"
        BorderThickness="{ThemeResource NavigationViewBorderThickness}"
        CompactPaneLength="{TemplateBinding CompactPaneLength}"
        DisplayMode="Inline"
        IsPaneOpen="{Binding RelativeSource={RelativeSource TemplatedParent}, Path=IsPaneOpen, Mode=TwoWay}"
        IsTabStop="False"
        PaneBackground="{ThemeResource NavigationViewDefaultPaneBackground}">

```

