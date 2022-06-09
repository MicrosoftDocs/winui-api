---
-api-id: P:Microsoft.UI.Xaml.Controls.SemanticZoom.ZoomedOutView
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ISemanticZoomInformation ZoomedOutView { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.SemanticZoom.ZoomedOutView

## -description
Gets or sets the zoomed-out view of the [SemanticZoom](semanticzoom.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<SemanticZoom ...>
  <SemanticZoom.ZoomedOutView>
    zoomedOutViewContent
  </SemanticZoom.ZoomedOut>
</SemanticZoom>

```


## -xaml-values
<dl><dt>zoomedOutViewContent</dt><dd>zoomedOutViewContentA single object element for a class that implements ISemanticZoomInfo (typically this is a practical ListViewBase implementation such as GridView).</dd>
</dl>
## -property-value
An object that implements [ISemanticZoomInfo](isemanticzoominformation.md). Typically this is a practical [ListViewBase](listviewbase.md) implementation such as [GridView](gridview.md).

## -remarks

## -examples

## -see-also
