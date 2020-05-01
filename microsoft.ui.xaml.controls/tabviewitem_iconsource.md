---
-api-id: P:Microsoft.UI.Xaml.Controls.TabViewItem.IconSource
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TabViewItem.IconSource

<!--
public Microsoft.UI.Xaml.Controls.IconSource IconSource { get; set; }
-->

## -description

Gets or sets the value for the IconSource to be displayed within the tab.

## -property-value

## -remarks

## -see-also

## -examples

``` xml
<TabView>
    <TabView.TabItems>
        <TabViewItem Header="Home" IsClosable="False">
            <TabViewItem.IconSource>
                <SymbolIconSource Symbol="Home" />
            </TabViewItem.IconSource>
            <!-- The content of the TabViewItem -->
        </TabViewItem>
    </TabView.TabItems>
</TabView>
```
