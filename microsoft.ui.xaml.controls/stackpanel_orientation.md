---
-api-id: P:Microsoft.UI.Xaml.Controls.StackPanel.Orientation
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Orientation Orientation { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.StackPanel.Orientation

## -description
Gets or sets the dimension by which child elements are stacked.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<StackPanel Orientation="Horizontal"/>
-or-
<StackPanel Orientation="Vertical"/>
```


## -property-value
One of the enumeration values that specifies the orientation of child elements. The default is **Vertical**.
## -remarks

## -examples
The following example creates a horizontal list of items by setting the Orientation property to **Horizontal**.

[!code-xaml[LayoutOvwStackPanel_2](../microsoft.ui.xaml/code/layout_ovw_all/CSharp/MainPage.xaml#SnippetLayoutOvwStackPanel_2)]

## -see-also
