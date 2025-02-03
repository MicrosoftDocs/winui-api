---
-api-id: P:Microsoft.UI.Xaml.Controls.TabViewItem.IconSource
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TabViewItem.IconSource

<!--
public Microsoft.UI.Xaml.Controls.IconSource IconSource { get; set; }
-->

## -description

Gets or sets the icon to be displayed within the tab.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The icon to be displayed within the tab.

## -remarks

If the [Header](tabviewitem_header.md) property is set, the icon appears inside the tab UI to the left of the header content.

## -see-also

[Header](tabviewitem_header.md)

## -examples

``` xaml
<!-- xmlns:muxc="using:Microsoft.UI.Xaml.Controls" -->

<muxc:TabView>
    <muxc:TabView.TabItems>
        <muxc:TabViewItem Header="Home" IsClosable="False">
            <muxc:TabViewItem.IconSource>
                <muxc:SymbolIconSource Symbol="Home" />
            </muxc:TabViewItem.IconSource>
            <!-- The content of the TabViewItem -->
        </muxc:TabViewItem>
    </muxc:TabView.TabItems>
</muxc:TabView>
```
