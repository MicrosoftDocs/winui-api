---
-api-id: T:Microsoft.UI.Xaml.Controls.TabView
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.TabView

<!--
public class TabView : Windows.UI.Xaml.Controls.Control
-->

## -description

The TabView control is a way to display a set of tabs and their respective content. Tab controls are useful for displaying several pages (or documents) of content while giving a user the capability to rearrange, open, or close new tabs.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

For more info, design guidance, and code examples, see [Tab view](/windows/apps/design/controls/tab-view).

### Control style and template

You can modify the default [Style](/uwp/api/windows.ui.xaml.frameworkelement.style) and [ControlTemplate](/uwp/api/windows.ui.xaml.controls.controltemplate) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the WinUI (Microsoft.UI.Xaml) NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`. Styles and resources from different versions of WinUI might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template (modifying these resources is preferred to setting properties). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -see-also

[TabViewItem](tabviewitem.md), [TabViewCloseButtonOverlayMode](tabviewclosebuttonoverlaymode.md), [Tab view](/windows/apps/design/controls/tab-view)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Tab view](/windows/apps/design/controls/tab-view).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see TabView in action](winui2gallery:/item/TabView).

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

This example creates a simple TabView along with event handlers to support opening and closing tabs. The _Home_ tab is defined in XAML and can't be closed. The `TabView_AddTabButtonClick` event handler shows how to add a new [TabViewItem](tabviewitem.md) in code.

``` xaml
<!-- xmlns:muxc="using:Microsoft.UI.Xaml.Controls" -->

<muxc:TabView VerticalAlignment="Stretch"
         AddTabButtonClick="TabView_AddTabButtonClick"
         TabCloseRequested="TabView_TabCloseRequested">
    <muxc:TabViewItem Header="Home" IsClosable="False">
        <muxc:TabViewItem.IconSource>
            <muxc:SymbolIconSource Symbol="Home" />
        </muxc:TabViewItem.IconSource>
        <muxc:TabViewItem.Content>
            <StackPanel Padding="12">
                <TextBlock Text="TabView content" 
                           Style="{ThemeResource TitleTextBlockStyle}"/>
            </StackPanel>
        </muxc:TabViewItem.Content>
    </muxc:TabViewItem>
</muxc:TabView>
```

``` csharp
private void TabView_AddTabButtonClick(TabView sender, object args)
{
    var newTab = new TabViewItem();
    newTab.Header = $"New Document {sender.TabItems.Count}";
    newTab.IconSource = new Microsoft.UI.Xaml.Controls.SymbolIconSource() { Symbol = Symbol.Document };
    newTab.Content = new TextBlock()
    {
        Text = $"Content for new tab {sender.TabItems.Count}.",
        Padding = new Thickness(12)
    };
    sender.TabItems.Add(newTab);
    sender.SelectedItem = newTab;
}

private void TabView_TabCloseRequested(TabView sender, TabViewTabCloseRequestedEventArgs args)
{
    sender.TabItems.Remove(args.Tab);
}

```
