---
-api-id: M:Microsoft.UI.Xaml.Media.VisualTreeHelper.DisconnectChildrenRecursive(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public void DisconnectChildrenRecursive(Windows.UI.Xaml.UIElement element)
-->

# Microsoft.UI.Xaml.Media.VisualTreeHelper.DisconnectChildrenRecursive

## -description
Explicitly removes all references from a target [UIElement](../microsoft.ui.xaml/uielement.md), with the goal of cleaning up reference cycles.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param element
The target object to disconnect children and remove references from.

## -remarks
This method is not intended for typical app or user code scenarios. Instead, it is intended for scenarios where a visual tree is hosted by some other application, such as a designer or code analysis tool. In most cases the scenario is that the visual tree is being cleared because it is about to be rebuilt based on saved information plus changes.

## -examples

## -see-also
