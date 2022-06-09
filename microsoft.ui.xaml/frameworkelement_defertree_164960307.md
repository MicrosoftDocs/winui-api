---
-api-id: M:Microsoft.UI.Xaml.FrameworkElement.DeferTree(Microsoft.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax.
public void FrameworkElement.DeferTree(DependencyObject element)
-->

# Microsoft.UI.Xaml.FrameworkElement.DeferTree


## -description

Removes the specified element from the XAML visual tree in a way that it can be undeferred later.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param element

The element to remove from the XAML visual tree.

## -remarks

This API is part of the implementation detail of x:Load, and should not be used directly. Instead use the generated UnloadObject API in a page or user control. This will also release any references due to x:Name or x:Bind.

## -see-also

x:Load attribute

## -examples

