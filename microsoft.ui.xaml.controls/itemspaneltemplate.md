---
-api-id: T:Microsoft.UI.Xaml.Controls.ItemsPanelTemplate
-api-type: winrt class
---

<!-- Class syntax.
public class ItemsPanelTemplate : Windows.UI.Xaml.FrameworkTemplate, Windows.UI.Xaml.Controls.IItemsPanelTemplate
-->

# Microsoft.UI.Xaml.Controls.ItemsPanelTemplate

## -description
Specifies the panel that the [ItemsPresenter](itemspresenter.md) creates for the layout of the items of an [ItemsControl](itemscontrol.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ItemsPanelTemplate ...>
  templateRootElement
</ItemsPanelTemplate>
```


## -remarks
An ItemsPanelTemplate object element should contain exactly one [FrameworkElement](../microsoft.ui.xaml/frameworkelement.md)-derived class that serves as the root element for items. In most cases this is a [Panel](panel.md)-derived class. The expanded template serves as the parent for the realized items and there generally is more than one item. Therefore the XAML content property of the intended root element of an ItemsPanelTemplate should support a collection, as [Panel.Children](panel_children.md) does.

> [!IMPORTANT]
> The root element of the template declared for the ItemsPanelTemplate in the [GroupStyle.Panel](groupstyle_panel.md) property cannot be a virtualizing panel. Virtualizing panels are defined as any type that derives from [VirtualizingPanel](virtualizingpanel.md), for example the [VirtualizingStackPanel](virtualizingstackpanel.md) class.

## -examples

## -see-also
[FrameworkTemplate](../microsoft.ui.xaml/frameworktemplate.md)
