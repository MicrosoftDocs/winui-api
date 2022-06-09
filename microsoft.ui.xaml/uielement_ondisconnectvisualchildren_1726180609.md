---
-api-id: M:Microsoft.UI.Xaml.UIElement.OnDisconnectVisualChildren
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnDisconnectVisualChildren()
-->

# Microsoft.UI.Xaml.UIElement.OnDisconnectVisualChildren

## -description
Override this method to implement how layout and logic should behave when items are removed from a class-specific content or children property.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
[UIElement](uielement.md) does not define any of the content model properties that OnDisconnectVisualChildren might act upon. Such properties are introduced deeper in an inheritance, for example at the [ContentControl](../microsoft.ui.xaml.controls/contentcontrol.md) level.

[FrameworkElement](frameworkelement.md) uses an OnDisconnectVisualChildren override to clear values from [DataContext](frameworkelement_datacontext.md) and [Tag](frameworkelement_tag.md). In general, if you override this method you should always call the base implementation so that the framework-intentional behavior that acts on OnDisconnectVisualChildren can be preserved.

[VisualTreeHelper.DisconnectChildrenRecursive](/uwp/api/windows.ui.xaml.media.visualtreehelper.disconnectchildrenrecursive(windows.ui.xaml.uielement)) is a similar static helper API that can be called by app code.

## -examples

## -see-also
[VisualTreeHelper](../microsoft.ui.xaml.media/visualtreehelper.md), [VisualTreeHelper.DisconnectChildrenRecursive](/uwp/api/windows.ui.xaml.media.visualtreehelper.disconnectchildrenrecursive(windows.ui.xaml.uielement))
