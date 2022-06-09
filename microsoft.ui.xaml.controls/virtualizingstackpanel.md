---
-api-id: T:Microsoft.UI.Xaml.Controls.VirtualizingStackPanel
-api-type: winrt class
---

<!-- Class syntax.
public class VirtualizingStackPanel : Windows.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel, Windows.UI.Xaml.Controls.IVirtualizingStackPanel, Windows.UI.Xaml.Controls.IVirtualizingStackPanelOverrides
-->

# Microsoft.UI.Xaml.Controls.VirtualizingStackPanel

## -description
Arranges and virtualizes content on a single line that is oriented either horizontally or vertically. Can only be used to display items in an [ItemsControl](itemscontrol.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<VirtualizingStackPanel .../>
-or-
<VirtualizingStackPanel ...>
  oneOrMoreChildren
</VirtualizingStackPanel>

```


## -remarks
VirtualizingStackPanel can only be used to display items in an [ItemsControl](itemscontrol.md). A primary scenario for VirtualizingStackPanel is that it provides the items panel template behavior for [FlipView](flipview.md) and [ListBox](listbox.md) in default templates.

> [!NOTE]
> Starting in Windows 8.1, [ItemsStackPanel](itemsstackpanel.md) is used as the default [ItemsPanel](itemscontrol_itemspanel.md) for [ListView](listview.md). If you modify the [ItemsPanel](itemscontrol_itemspanel.md), we recommend you use [ItemsStackPanel](itemsstackpanel.md) or [ItemsWrapGrid](itemswrapgrid.md) instead of VirtualizingStackPanel or [WrapGrid](wrapgrid.md).

### XAML attached properties

VirtualizingStackPanel is the host service class for several [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](/uwp/api/windows.ui.xaml.dependencyobject.getvalue(windows.ui.xaml.dependencyproperty)) or [SetValue](/uwp/api/windows.ui.xaml.dependencyobject.setvalue(windows.ui.xaml.dependencyproperty,system.object)) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| IsVirtualizing | See Remarks<ul><li>Type: Boolean</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.virtualizingstackpanel.isvirtualizingproperty">IsVirtualizingProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.virtualizingstackpanel.getisvirtualizing">GetIsVirtualizing</a></li></ul>**VirtualizingStackPanel.IsVirtualizing** uses the attached property model as a property store, but does not support a Extensible Application Markup Language (XAML) usage. Instead, the property serves as a sentinel that any VirtualizingStackPanel child element can check to determine whether that child is currently being represented as virtualized. To find out if an item is being virtualized, call [GetIsVirtualizing](virtualizingstackpanel_getisvirtualizing_481559423.md), passing the item as the input parameter. |
| VirtualizationMode | Gets or sets a value that indicates the virtualization mode of items being virtualized by a parent VirtualizingStackPanel and items set. <ul><li>Type: [VirtualizationMode](virtualizationmode.md)</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.virtualizingstackpanel.virtualizationmodeproperty">VirtualizationModeProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.virtualizingstackpanel.getvirtualizationmode">GetVirtualizationMode</a>, <a href="/uwp/api/windows.ui.xaml.controls.virtualizingstackpanel.setvirtualizationmode">SetVirtualizationMode</a></li></ul> Child elements set this property in markup to declare how the item should be virtualized when included as a VirtualizingStackPanel child element.|

## -examples

## -see-also
[OrientedVirtualizingPanel](../microsoft.ui.xaml.controls.primitives/orientedvirtualizingpanel.md), [IScrollSnapPointsInfo](../microsoft.ui.xaml.controls.primitives/iscrollsnappointsinfo.md), [ItemsControl.ItemsPanel](itemscontrol_itemspanel.md), [ItemsPanelTemplate](itemspaneltemplate.md), [Quickstart: Adding ListView and GridView controls](/previous-versions/windows/apps/hh780650(v=win.10))
