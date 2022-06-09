---
-api-id: P:Microsoft.UI.Xaml.UIElement.AccessKeyScopeOwner
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyObject AccessKeyScopeOwner { get;  set; }
-->

# Microsoft.UI.Xaml.UIElement.AccessKeyScopeOwner

## -description
Gets or sets a source element that provides the access key scope for this element, even if it's not in the visual tree of the source element.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The element that defines the access key scope.

## -remarks
The source element must have it's [IsAccessKeyScope](uielement_isaccesskeyscope.md) property set to **true**.

## -examples

## -see-also
[Access keys](/windows/apps/design/input/access-keys)
