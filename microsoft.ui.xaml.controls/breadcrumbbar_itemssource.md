---
-api-id: P:Microsoft.UI.Xaml.Controls.BreadcrumbBar.ItemsSource
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.BreadcrumbBar.ItemsSource

<!--
public object ItemsSource { get; set; }
-->


## -description

Gets or sets an object source used to generate the content of the `BreadcrumbBar`.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

An object source used to generate the content of the `BreadcrumbBar`.

## -remarks

The [BreadcrumbBar](breadcrumbbar.md) control does not have an `Items` property, it only has an `ItemsSource` property. This means you can't populate the breadcrumbs in XAML or by adding them directly to an `Items` collection in code. Instead, you create a collection and connect the `ItemsSource` property to it in code or using data binding.

For more info, design guidance, and code examples, see [Breadcrumb bar overview](/windows/apps/design/controls/breadcrumbbar).

## -see-also

[BreadcrumbBar](breadcrumbbar.md), [Breadcrumb bar overview](/windows/apps/design/controls/breadcrumbbar)

## -examples


