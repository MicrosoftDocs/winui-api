---
-api-id: T:Microsoft.UI.Xaml.Controls.RelativePanel
-api-type: winrt class
---

<!-- Class syntax.
public class RelativePanel : Windows.UI.Xaml.Controls.Panel, Windows.UI.Xaml.Controls.IRelativePanel
-->

# Microsoft.UI.Xaml.Controls.RelativePanel

## -description
Defines an area within which you can position and align child objects in relation to each other or the parent panel.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<RelativePanel ...>
  oneOrMoreUIElements
</RelativePanel>
-or-
<RelativePanel .../>
```


## -remarks

RelativePanel is a layout container that is useful for creating UI that do not have a clear linear pattern; that is, layouts that are not fundamentally stacked, wrapped, or tabular, where you might naturally use a [StackPanel](stackpanel.md) or [Grid](grid.md).

If your UI consists of multiple nested panels, RelativePanel is a good option to consider.

Here's an example of a UI using a RelativePanel for its layout:

<img alt="Relative panel control" src="images/controls/RelativePanelBasic.png" />

```xaml
<RelativePanel BorderBrush="Gray" BorderThickness="10">
    <Rectangle x:Name="RedRect" Fill="Red" MinHeight="100" MinWidth="100"/>
    <Rectangle x:Name="BlueRect" Fill="Blue" MinHeight="100" MinWidth="100" 
               RelativePanel.RightOf="RedRect"/>
    <!-- Width is not set on the green and yellow rectangles.
         It's determined by the RelativePanel properties. -->
    <Rectangle x:Name="GreenRect" Fill="Green" MinHeight="100" Margin="0,5,0,0" 
               RelativePanel.Below="RedRect" 
               RelativePanel.AlignLeftWith="RedRect" 
               RelativePanel.AlignRightWith="BlueRect"/>
    <Rectangle Fill="Yellow" MinHeight="100" 
               RelativePanel.Below="GreenRect" 
               RelativePanel.AlignLeftWith="BlueRect" 
               RelativePanel.AlignRightWithPanel="True"/>
</RelativePanel>
```

RelativePanel, used in conjunction with [AdaptiveTrigger](../microsoft.ui.xaml/adaptivetrigger.md) s, can be a powerful tool to create responsive UI that scales well across different screen sizes. For more examples, see the [XAML Responsive Techniques sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlResponsiveTechniques?amp;amp;clcid=0x409).

### Default position

By default, any unconstrained element declared as a child of the RelativePanel is given the entire available space and positioned at the (0, 0) coordinates (upper left corner) of the panel. So, if you are positioning a second element relative to an unconstrained element, keep in mind that the second element might get pushed out of the panel.

In this example, `RectA` doesn't have any constraints, so it's positioned at (0,0). `RectB` is not shown on the screen because it is declared to be [Above](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties)  `RectA` and is therefore pushed out of the panel.

```xaml
<RelativePanel>
    <Rectangle Name="RectA" Fill="Red" Height="40" Width="40"/>
    <Rectangle Name="RectB" Fill="Blue" Height="40" Width="40"
               RelativePanel.Above="RectA"/>
</RelativePanel>
```

### Circular dependency

A circular dependency occurs when two elements inside a RelativePanel declare relationships with each other in any direction. For example, this XAML results in a design-time exception, "RelativePanel error: Circular dependency detected. Layout could not complete."

```xaml
<RelativePanel>
    <Rectangle Name="RectA" Fill="Red" Height="40" Width="40"
               RelativePanel.Above="RectB"/>
    <Rectangle Name="RectB" Fill="Blue" Height="40" Width="40"
               RelativePanel.Below="RectA"/>
</RelativePanel>
```

### Conflicting relationships

If you set multiple relationships that target the same edge of an element, you might have conflicting relationships in your layout as a result. When this happens, the relationships are applied in the following order of priority:
+ Panel alignment relationships ([AlignTopWithPanel](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties), [AlignLeftWithPanel](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties), …) are applied first.
+ Sibling alignment relationships ([AlignTopWith](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties), [AlignLeftWith](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties), …) are applied second.
+ Sibling positional relationships ([Above](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties), [Below](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties), [RightOf](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties), [LeftOf](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties)) are applied last.

The panel-center alignment properties ([AlignVerticalCenterWith](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties), [AlignHorizontalCenterWithPanel](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties), ...) are typically used independently of other constraints and are applied if there is no conflict.

The [HorizontalAlignment](../microsoft.ui.xaml/frameworkelement_horizontalalignment.md) and [VerticalAlignment](../microsoft.ui.xaml/frameworkelement_verticalalignment.md) properties on UI elements are applied after relationship properties are evaluated and applied. These properties control the placement of the element within the available size for the element, if the desired size is smaller than the available size.

### Border properties

RelativePanel defines border properties that let you draw a border around the RelativePanel without using an additional [Border](border.md) element. The properties are [RelativePanel.BorderBrush](relativepanel_borderbrush.md), [RelativePanel.BorderThickness](relativepanel_borderthickness.md), [RelativePanel.CornerRadius](relativepanel_cornerradius.md), and [RelativePanel.Padding](relativepanel_padding.md).

```xaml
<RelativePanel BorderBrush="Red" BorderThickness="2" CornerRadius="10" Padding="12">
    <TextBox x:Name="textBox1" RelativePanel.AlignLeftWithPanel="True"/>
    <Button Content="Submit" RelativePanel.Below="textBox1"/>
</RelativePanel>
```

### XAML attached properties

RelativePanel is the host service class for several [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](/uwp/api/windows.ui.xaml.dependencyobject.getvalue(windows.ui.xaml.dependencyproperty)) or [SetValue](/uwp/api/windows.ui.xaml.dependencyobject.setvalue(windows.ui.xaml.dependencyproperty,system.object)) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| Above | Gets or sets a target element that this element is positioned above.<ul><li>Type: object</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.aboveproperty">AboveProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getabove">GetAbove</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setabove">SetAbove</a></li></ul> |
| AlignBottomWith | Gets or sets a target element that this element's bottom edge is aligned with.<ul><li>Type: object</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.alignbottomwithproperty">AlignBottomWithProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getalignbottomwith">GetAlignBottomWith</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setalignbottomwith">SetAlignBottomWith</a></li></ul> |
| AlignBottomWithPanel | Gets or sets a value that indicates whether this element's bottom edge is touching the panel's bottom edge.<ul><li>Type: Boolean</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.alignbottomwithpanelproperty">AlignBottomWithPanelProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getalignbottomwithpanel">GetAlignBottomWithPanel</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setalignbottomwithpanel">SetAlignBottomWithPanel</a></li></ul> |
| AlignHorizontalCenterWith | Gets or sets a target element that this element's horizontal center is aligned with.<ul><li>Type: object</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.alignhorizontalcenterwithproperty">AlignHorizontalCenterWithProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getalignhorizontalcenterwith">GetAlignHorizontalCenterWith</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setalignhorizontalcenterwith">SetAlignHorizontalCenterWith</a></li></ul> |
| AlignHorizontalCenterWithPanel | Gets or sets a value that indicates whether this element's horizontal axis is touching the panel's horizontal axis.<ul><li>Type: Boolean</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.alignhorizontalcenterwithpanelproperty">AlignHorizontalCenterWithPanelProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getalignhorizontalcenterwithpanel">GetAlignHorizontalCenterWithPanel</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setalignhorizontalcenterwithpanel">SetAlignHorizontalCenterWithPanel</a></li></ul> |
| AlignLeftWith | Gets or sets a target element that this element's left edge is aligned with.<ul><li>Type: object</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.alignleftwithproperty">AlignLeftWithProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getalignleftwith">GetAlignLeftWith</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setalignleftwith">SetAlignLeftWith</a></li></ul> |
| AlignLeftWithPanel | Gets or sets a value that indicates whether this element's left edge is touching the panel's left edge.<ul><li>Type: Boolean</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.alignleftwithpanelproperty">AlignLeftWithPanelProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getalignleftwithpanel">GetAlignLeftWithPanel</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setalignleftwithpanel">SetAlignLeftWithPanel</a></li></ul> |
| AlignRightWith | Gets or sets a target element that this element's right edge is aligned with.<ul><li>Type: object</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.alignrightwithproperty">AlignRightWithProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getalignrightwith">GetAlignRightWith</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setalignrightwith">SetAlignRightWith</a></li></ul> |
| AlignRightWithPanel | Gets or sets a value that indicates whether this element's right edge is touching the panel's right edge.<ul><li>Type: Boolean</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.alignrightwithpanelproperty">AlignRightWithPanelProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getalignrightwithpanel">GetAlignRightWithPanel</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setalignrightwithpanel">SetAlignRightWithPanel</a></li></ul> |
| AlignTopWith | Gets or sets a target element that this element's top edge is aligned with.<ul><li>Type: object</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.aligntopwithproperty">AlignTopWithProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getaligntopwith">GetAlignTopWith</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setaligntopwith">SetAlignTopWith</a></li></ul> |
| AlignTopWithPanel | Gets or sets a value that indicates whether this element's top edge is touching the panel's top edge.<ul><li>Type: Boolean</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.aligntopwithpanelproperty">AlignTopWithPanelProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getaligntopwithpanel">GetAlignTopWithPanel</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setaligntopwithpanel">SetAlignTopWithPanel</a></li></ul> |
| AlignVerticalCenterWith | Gets or sets a target element that this element's vertical center is aligned with.<ul><li>Type: object</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.alignverticalcenterwithproperty">AlignVerticalCenterWithProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getalignverticalcenterwith">GetAlignVerticalCenterWith</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setalignverticalcenterwith">SetAlignVerticalCenterWith</a></li></ul> |
| AlignVerticalCenterWithPanel | Gets or sets a value that indicates whether this element's vertical axis is touching the panel's horizontal axis.<ul><li>Type: Boolean</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.alignverticalcenterwithpanelproperty">AlignVerticalCenterWithPanelProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getalignverticalcenterwithpanel">GetAlignVerticalCenterWithPanel</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setalignverticalcenterwithpanel">SetAlignVerticalCenterWithPanel</a></li></ul> |
| Below | Gets or sets a target element that this element is positioned below.<ul><li>Type: object</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.belowproperty">BelowProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getbelow">GetBelow</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setbelow">SetBelow</a></li></ul> |
| LeftOf | Gets or sets a target element that this element is positioned to the left of.<ul><li>Type: object</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.leftofproperty">LeftOfProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getleftof">GetLeftOf</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setleftof">SetLeftOf</a></li></ul> |
| RightOf | Gets or sets a target element that this element is positioned to the right of.<ul><li>Type: object</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.rightofproperty">RightOfProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.getrightof">GetRightOf</a>, <a href="/uwp/api/windows.ui.xaml.controls.relativepanel.setrightof">SetRightOf</a></li></ul> |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/apps/design/layout/layout-panels#relativepanel).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/RelativePanel) or [**WinUI 2 Gallery**](winui2gallery:/item/RelativePanel).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


## -see-also
[Panel](panel.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml), [Quickstart: Adding layout controls](/previous-versions/windows/apps/hh969155(v=win.10)), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding), [Canvas](canvas.md), [Grid](grid.md), [StackPanel](stackpanel.md), [VariableSizedWrapGrid](variablesizedwrapgrid.md), [Controls list](/windows/apps/design/controls/), [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function)
