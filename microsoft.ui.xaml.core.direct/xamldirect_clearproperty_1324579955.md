---
-api-id: M:Microsoft.UI.Xaml.Core.Direct.XamlDirect.ClearProperty(Microsoft.UI.Xaml.Core.Direct.IXamlDirectObject,Microsoft.UI.Xaml.Core.Direct.XamlPropertyIndex)
-api-type: winrt method
---

<!-- Method syntax.
public void XamlDirect.ClearProperty(IXamlDirectObject xamlDirectObject, XamlPropertyIndex propertyIndex)
-->

# Microsoft.UI.Xaml.Core.Direct.XamlDirect.ClearProperty

## -description
Clears the value of the specified property on a given [IXamlDirectObject](ixamldirectobject.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param xamlDirectObject
A reference to the specific [IXamlDirectObject](ixamldirectobject.md).

### -param propertyIndex
A reference to the property to be cleared from the list of supported properties in [XamlPropertyIndex](xamlpropertyindex.md) enum.

## -examples
The following example shows how to clear the value of a [Border](../microsoft.ui.xaml.controls/border.md) element's [MinHeight](../microsoft.ui.xaml/frameworkelement_minheight.md) property through [XamlDirect](xamldirect.md) APIs.

```C#
XamlDirect xd = XamlDirect.GetDefault();
IXamlDirectObject border = xd.CreateInstance(XamlTypeIndex.Border);
xd.ClearProperty(border, XamlPropertyIndex.FrameworkElement_MinHeight);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();
IXamlDirectObject^ border = xd->CreateInstance(XamlTypeIndex::Border);
xd->ClearProperty(border, XamlPropertyIndex::FrameworkElement_MinHeight);
```

