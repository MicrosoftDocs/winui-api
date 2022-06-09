---
-api-id: P:Microsoft.UI.Xaml.Controls.GroupStyle.ContainerStyle
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Style ContainerStyle { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.GroupStyle.ContainerStyle

## -description
> [!NOTE]
> ContainerStyle may be altered or unavailable for releases after Windows 8.1 and is not supported for [ItemsControl.GroupStyle](itemscontrol_groupstyle.md).

Gets or sets the style that is applied to the [GroupItem](groupitem.md) generated for each item.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<GroupStyle ContainerStyle="styleReference" />
- or -
<GroupStyle>
  <GroupStyle.ContainerStyle>
    singleStyle
  </GroupStyle.ContainerStyle>
</GroupStyle>  
```


## -xaml-values
<dl><dt>styleReference</dt><dd>styleReferenceA reference to an existing Style. Typically this is a keyed resource, which you reference through {StaticResource} markup extension.</dd>
<dt>singleStyle</dt><dd>singleStyleA single Style object element defined inline, which declares the style and setters for the group item container.</dd>
</dl>
## -property-value
The style that is applied to the [GroupItem](groupitem.md) generated for each item. The default is **null**.

## -remarks

## -examples

## -see-also
[HeaderContainerStyle](groupstyle_headercontainerstyle.md), [How to group items in a list or grid](/previous-versions/windows/apps/hh780627(v=win.10))
