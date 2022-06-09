---
-api-id: P:Microsoft.UI.Xaml.Controls.GroupStyle.ContainerStyleSelector
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.StyleSelector ContainerStyleSelector { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.GroupStyle.ContainerStyleSelector

## -description
> [!NOTE]
> ContainerStyleSelector may be altered or unavailable for releases after Windows 8.1 and is not supported for [ItemsControl.GroupStyle](itemscontrol_groupstyle.md).

Gets or sets a reference to a custom [StyleSelector](styleselector.md) logic class. The [StyleSelector](styleselector.md) referenced by this property returns a style to apply to each generated [GroupItem](groupitem.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<GroupStyle ContainerStyleSelector="styleSelectorReference" />
```


## -xaml-values
<dl><dt>styleSelectorReference</dt><dd>styleSelectorReferenceA reference to an existing StyleSelector. Typically this is a keyed resource, which you reference through {StaticResource} markup extension.</dd>
</dl>
## -property-value
An object that derives from [StyleSelector](styleselector.md). The default is **null**.

## -remarks

## -examples

## -see-also
