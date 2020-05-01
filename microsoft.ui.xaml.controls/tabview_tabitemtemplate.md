---
-api-id: P:Microsoft.UI.Xaml.Controls.TabView.TabItemTemplate
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TabView.TabItemTemplate

<!--
public Windows.UI.Xaml.DataTemplate TabItemTemplate { get; set; }
-->

## -description

Gets or sets the DataTemplate used to display each item.

## -property-value

## -remarks

Use TabItemTemplate to customize the look of each generated TabViewItem when using the TabItemsSource as the data source for the tabs.

## -see-also

## -examples

``` xml
<TabView TabItemsSource="{x:Bind myDatas, Mode=OneWay}">
    <TabView.TabItemTemplate>
        <DataTemplate x:DataType="local1:MyData">
            <TabViewItem Header="{x:Bind DataHeader}" IconSource="{x:Bind DataIconSource}" Content="{x:Bind DataContent}" />
        </DataTemplate>
    </TabView.TabItemTemplate>
</TabView>
```