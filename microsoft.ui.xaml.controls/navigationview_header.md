---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationView.Header
-api-type: winrt property
---
<!-- Property syntax.
public object Header { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.NavigationView.Header


## -description

Gets or sets the header content.


**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The header content for the NavigationView.


## -remarks


## -see-also


## -examples


## -xaml-syntax

```xaml
<NavigationView Header="headerString"/>
```

```xaml
<NavigationView>
  <NavigationView.Header>
    headerObject
  </NavigationView.Header>
</NavigationView>
```


## -xaml-values

<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>


