---
-api-id: P:Microsoft.UI.Xaml.Controls.ItemsStackPanel.AreStickyGroupHeadersEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool AreStickyGroupHeadersEnabled { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ItemsStackPanel.AreStickyGroupHeadersEnabled

## -description
Gets or sets a value that specifies whether a group header moves with the group when the group is panned vertically.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
**true** if the group header moves with the group when the group is panned vertically; otherwise, **false**. The default is **true**.

## -remarks
Group headers can be sticky only when the group is panned vertically and the [GroupHeaderPlacement](itemsstackpanel_groupheaderplacement.md) is **Top**. If the panel's [Orientation](itemsstackpanel_orientation.md) is **Horizontal** or [GroupHeaderPlacement](itemsstackpanel_groupheaderplacement.md) is not **Top**, this property is ignored.

## -examples
```xaml
<ListView>
    <ListView.ItemsPanel> 
        <ItemsPanelTemplate>
            <ItemsStackPanel AreStickyGroupHeadersEnabled="False"/>  
        </ItemsPanelTemplate> 
    </ListView.ItemsPanel> 
</ListView> 

```



## -see-also
