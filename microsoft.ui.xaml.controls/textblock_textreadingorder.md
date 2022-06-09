---
-api-id: P:Microsoft.UI.Xaml.Controls.TextBlock.TextReadingOrder
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.TextReadingOrder TextReadingOrder { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TextBlock.TextReadingOrder

## -description
Gets or sets a value that indicates how the reading order is determined for the [TextBlock](textblock.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<TextBlock TextReadingOrder="textReadingOrderValue"/>
```


## -xaml-values
<dl><dt>textReadingOrderValue</dt><dd>textReadingOrderValue A named constant of the TextReadingOrder enumeration, such as DetectFromContent.</dd>
</dl>
## -property-value
A value that indicates how the reading order is determined for the [TextBlock](textblock.md). The default is **DetectFromContent**.

## -remarks
This property can be useful when the base direction of the text is unknown, and may not match the user's language or direction. For more info, see the Remarks section of the [TextReadingOrder](../microsoft.ui.xaml/textreadingorder.md) enumeration or [How to support bidirectional UI](/previous-versions/windows/apps/jj712703(v=win.10)).

> [!NOTE]
> In Windows 8.1, the default value is **0**, **Default**. Starting with Windows 10, the enumeration value **0** has the constant name **UseFlowDirection**, and is not the default value.

## -examples

## -see-also
[TextReadingOrder](../microsoft.ui.xaml/textreadingorder.md), [How to support bidirectional UI](/previous-versions/windows/apps/jj712703(v=win.10))
