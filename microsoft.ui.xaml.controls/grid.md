---
-api-id: T:Microsoft.UI.Xaml.Controls.Grid
-api-type: winrt class
---

<!-- Class syntax.
public class Grid : Windows.UI.Xaml.Controls.Panel, Windows.UI.Xaml.Controls.IGrid, Windows.UI.Xaml.Controls.IGrid2
-->

# Microsoft.UI.Xaml.Controls.Grid

## -description

Defines a flexible grid area that consists of columns and rows. Child elements of the Grid are measured and arranged according to their row/column assignments (set by using [Grid.Row](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) and [Grid.Column](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) attached properties) and other logic.

## -xaml-syntax

```xaml
<Grid ...>
  oneOrMoreUIElements
</Grid>
-or-
<Grid .../>
```

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/apps/design/layout/layout-panels#grid).

Grid is a layout panel that supports arranging child elements in rows and columns.

<img alt="Grid layout panel" src="images/controls/Grid.png" />

You typically define layout behavior for a Grid in XAML by providing one or more [RowDefinition](rowdefinition.md) elements as the value of [Grid.RowDefinitions](grid_rowdefinitions.md), and one or more [ColumnDefinition](columndefinition.md) elements as the value of [Grid.ColumnDefinitions](grid_columndefinitions.md). Then, you apply the [Grid.Row](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) and [Grid.Column](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) attached properties to each of the element children of the Grid, to indicate which row/column combination is used to position that element within the parent Grid.

To set the height of rows and the width of columns, you set [RowDefinition.Height](rowdefinition_height.md) for each [RowDefinition](rowdefinition.md) and [ColumnDefinition.Width](columndefinition_width.md) for each [ColumnDefinition](columndefinition.md). [ColumnDefinition.Width](columndefinition_width.md) and [RowDefinition.Height](rowdefinition_height.md) are the respective content properties of [ColumnDefinition](columndefinition.md) and [RowDefinition](rowdefinition.md).

By default, each row or column divides layout space equally. You can change this behavior either by providing absolute pixel values, or a **Star** sizing that divides available space using a weighted factor. For more info on how to use **Star** sizing in a Grid, see [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml) or [GridLength](../microsoft.ui.xaml/gridlength.md). You also can use an **Auto** sizing that sizes to content.

Note that there are two ways to define a Grid. If you are simply defining rows and columns *without* using data binding or defining properties such as MinHeight or MaxWidth, you can use the following succinct syntax:

[!code-xaml[GridSample1NewSyntax](../microsoft.ui.xaml.controls/code/UpdatedGridSamples/MainPage.xaml#SnippetGridSample1NewSyntax)]

If you need to add more details in your Grid definition, such as providing a row's MaxHeight or using data binding in a row/column definition, you should use the original, full-fledged Grid syntax:

[!code-xaml[GridSample1OldSyntax](../microsoft.ui.xaml.controls/code/UpdatedGridSamples/MainPage.xaml#SnippetGridSample1OldSyntax)]

To indicate that an element child should span multiple rows or multiple columns in the Grid, you can apply the [Grid.RowSpan](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) or [Grid.ColumnSpan](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) attached properties to child elements of a Grid.

By default, a Grid contains one row and one column.

Setting the [Margin](../microsoft.ui.xaml/frameworkelement_margin.md) property on the child elements in a Grid sets the distance between the element and its grid cell boundaries. The [HorizontalAlignment](../microsoft.ui.xaml/frameworkelement_horizontalalignment.md) and [VerticalAlignment](../microsoft.ui.xaml/frameworkelement_verticalalignment.md) properties describe how the child element should be positioned within the grid cell. You can precisely position child elements of a Grid by using a combination of the [Margin](../microsoft.ui.xaml/frameworkelement_margin.md) property and alignment properties. If you need even more control over the layout of individual child elements, consider using [VariableSizedWrapGrid](variablesizedwrapgrid.md).

[WrapGrid](wrapgrid.md) is another similar layout panel that has the benefit of better handling for content that's too wide, which might be clipped by a regular Grid depending on values of other layout properties.

An element in the first column that spans multiple rows can affect the height of each spanned row even if the first row has enough height to accommodate the element, and subsequent spanned rows would otherwise have a height of 0. For example, the second row in this Grid has its height set to 0, so the blue rectangle would not typically be visible. In this case, you might expect that the red ellipse would not affect the second row because the first row is tall enough to contain the ellipse. However, the Grid calculates the MinHeight of each row to be enough to accommodate the red ellipse, and then spans the element across the rows. As a result, the second row is given a MinHeight of 50, the red ellipse is centered in the 150px span, and half of the blue rectangle is visible in the second row.

> [!NOTE]
> (This example uses an element that spans columns, but also applies to an element in the first column that spans multiple rows.)

[!code-xaml[GridSample2](../microsoft.ui.xaml.controls/code/UpdatedGridSamples/MainPage.xaml#SnippetGridSample2)]


### Border properties

Grid defines border properties that let you draw a border around the Grid without using an additional [Border](border.md) element. The properties are [Grid.BorderBrush](grid_borderbrush.md), [Grid.BorderThickness](grid_borderthickness.md), [Grid.CornerRadius](grid_cornerradius.md), and [Grid.Padding](grid_padding.md).

```xaml
<Grid BorderBrush="Red" BorderThickness="2" CornerRadius="10" Padding="12">
    <TextBlock Text="Hello World!"/>
</Grid>
```

### **Grid** derived classes

Grid is the parent class for [SwapChainPanel](swapchainpanel.md) and [SwapChainBackgroundPanel](swapchainbackgroundpanel.md).

### XAML attached properties

Grid is the host service class for several [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview). These attached properties enable child elements to report how they should be positioned in their Grid parent.

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](/uwp/api/windows.ui.xaml.dependencyobject.getvalue(windows.ui.xaml.dependencyproperty)) or [SetValue](/uwp/api/windows.ui.xaml.dependencyobject.setvalue(windows.ui.xaml.dependencyproperty,system.object)) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| Column | Gets or sets the column alignment of an element when child layout is processed by a parent Grid layout container.<ul><li>Type: int</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.grid.columnproperty">ColumnProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.grid.getcolumn">GetColumn</a>, <a href="/uwp/api/windows.ui.xaml.controls.grid.setcolumn">SetColumn</a></li></ul>The value is the zero-based index of the Grid column that the element should appear within. Negative values are not permitted.|
| ColumnSpan | Gets or sets a value that indicates the total number of columns that the element content spans within a parent Grid.<ul><li>Type: int</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.grid.columnspanproperty">ColumnSpanProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.grid.getcolumnspan">GetColumnSpan</a>, <a href="/uwp/api/windows.ui.xaml.controls.grid.setcolumnspan">SetColumnSpan</a></li></ul> Zero or negative integer values are not permitted. Values that are greater than the total number of columns are treated as if they specified the total number and will span all columns.|
| Row | Gets or sets the row alignment of an element when child layout is processed by a parent Grid layout container.<ul><li>Type: int</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.grid.rowproperty">RowProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.grid.getrow">GetRow</a>, <a href="/uwp/api/windows.ui.xaml.controls.grid.setrow">SetRow</a></li></ul>The value is the zero-based index of the Grid row that the element should appear within. Negative values are not permitted.|
| RowSpan | Gets or sets a value that indicates the total number of rows that the element content spans within a parent Grid.<ul><li>Type: int</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.grid.rowspanproperty">RowSpanProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.grid.getrowspan">GetRowSpan</a>, <a href="/uwp/api/windows.ui.xaml.controls.grid.setrowspan">SetRowSpan</a></li></ul> Zero or negative integer values are not permitted. Values that are greater than the total number of rows are treated as if they specified the total number and will span all rows.|

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/apps/design/layout/layout-panels#grid).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/Grid) or [**WinUI 2 Gallery**](winui2gallery:/item/Grid).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/p/winui-3-controls-gallery/9p3jfpwwdzrc) and the [**WinUI 2 Gallery**](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).



This XAML example shows how to design a layout by using a Grid.

[!code-xaml[GridSample3](../microsoft.ui.xaml.controls/code/UpdatedGridSamples/MainPage.xaml#SnippetGridSample3)]

[!code-csharp[GridCsharpSample1](../microsoft.ui.xaml.controls/code/UpdatedGridSamples/MainPage.xaml.cs#SnippetGridCsharpSample1)]

## -see-also
[Panel](panel.md), [Grid.Row](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties), [Grid.Column](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties), [Define layouts](/windows/uwp/layout/layouts-with-xaml), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview), [Canvas](canvas.md), [StackPanel](stackpanel.md), [VariableSizedWrapGrid](variablesizedwrapgrid.md), [WrapGrid](wrapgrid.md), [Controls list](/windows/apps/design/controls/), [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function)
