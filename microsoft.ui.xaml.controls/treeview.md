---
-api-id: T:Microsoft.UI.Xaml.Controls.TreeView
-api-type: winrt class
---
<!-- Class syntax.
public class TreeView : Control, Control
-->

# Microsoft.UI.Xaml.Controls.TreeView

## -description

Represents a hierarchical list with expanding and collapsing nodes that contain nested items.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

### Control style and template

You can modify the default [Style](/uwp/api/windows.ui.xaml.frameworkelement.style) and [ControlTemplate](/uwp/api/windows.ui.xaml.controls.controltemplate) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the WinUI (Microsoft.UI.Xaml) NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`. Styles and resources from different versions of WinUI might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template (modifying these resources is preferred to setting properties). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -see-also

[TreeViewCollapsedEventArgs](treeviewcollapsedeventargs.md), [TreeViewDragItemsCompletedEventArgs](treeviewdragitemscompletedeventargs.md), [TreeViewDragItemsStartingEventArgs](treeviewdragitemsstartingeventargs.md), [TreeViewExpandingEventArgs](treeviewexpandingeventargs.md), [TreeViewItem](treeviewitem.md), [TreeViewItemInvokedEventArgs](treeviewiteminvokedeventargs.md), [TreeViewItemTemplateSettings](treeviewitemtemplatesettings.md), [TreeViewList](treeviewlist.md), [TreeViewNode](treeviewnode.md), [TreeViewSelectionMode](treeviewselectionmode.md), [TreeView overview](/windows/apps/design/controls/tree-view)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Tree view](/windows/apps/design/controls/tree-view).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see TreeView in action](winui2gallery:/item/TreeView).

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).
