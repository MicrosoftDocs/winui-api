---
-api-id: P:Microsoft.UI.Xaml.Controls.PivotItem.Header
-api-type: winrt property
---

<!-- Property syntax
public object Header { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.PivotItem.Header

## -description
Gets or sets the header for the [PivotItem](pivotitem.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<PivotItem Header="headerString"/>
- or -
<PivotItem>
  <PivotItem.Header>
    headerObject
  </PivotItem.Header>
</PivotItem>

```


## -xaml-values
<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
Returns [Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true).

## -remarks

## -examples

## -see-also
