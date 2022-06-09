---
-api-id: T:Microsoft.UI.Xaml.Controls.StretchDirection
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.StretchDirection : int
-->

# StretchDirection

## -description
Defines constants that specify the direction that content is scaled.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field UpOnly:0
The content scales upward only when it is smaller than the parent. If the content is larger, no scaling downward is performed.

### -field DownOnly:1
The content scales downward only when it is larger than the parent. If the content is smaller, no scaling upward is performed.

### -field Both:2
The content stretches to fit the parent according to the [Stretch](viewbox_stretch.md) property.


## -remarks

## -examples

## -see-also
