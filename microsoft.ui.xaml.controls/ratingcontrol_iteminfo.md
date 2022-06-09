---
-api-id: P:Microsoft.UI.Xaml.Controls.RatingControl.ItemInfo
-api-type: winrt property
---
<!-- Property syntax.
public RatingItemInfo ItemInfo { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.RatingControl.ItemInfo


## -description

Gets or sets info about the visual states of the items that represent a rating.


**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

A RatingItemInfo-derived object that contains details about the visual states of the items that represent a rating.


## -remarks

You can set the ItemInfo property to replace the default stars with other glyphs or images that represent a rating.


## -see-also


## -examples


## -xaml-syntax

```xaml
<RatingControl ItemInfo="resourceReferenceToRatingItemInfo"/>
```

```xaml
<RatingControl>
  <RatingControl.ItemInfo>
    ratingItemInfo
  </RatingControl.ItemInfo>
</RatingControl>
```


## -xaml-values

<dl><dt>resourceReferenceToRatingItemInfo</dt><dd>resourceReferenceToRatingItemInfoA resource reference to an existing RatingItemInfo-derived object from a resources collection. The resource reference must specify the desired RatingItemInfo by key through a {StaticResource} markup extension usage.</dd>
<dt>ratingItemInfo</dt><dd>ratingItemInfoDefinition for the RatingItemInfo-derived object.</dd>
</dl>


