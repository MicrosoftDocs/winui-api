---
-api-id: T:Microsoft.UI.Xaml.Controls.Grid
-api-type: winrt class
---

<!-- Class syntax.
public class Grid : Windows.UI.Xaml.Controls.Panel, Windows.UI.Xaml.Controls.IGrid, Windows.UI.Xaml.Controls.IGrid2
-->

# Microsoft.UI.Xaml.Controls.Grid

## -description
Defines a flexible grid area that consists of columns and rows. Child elements of the Grid are measured and arranged according to their row/column assignments (set by using [Grid.Row](/uwp/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) and [Grid.Column](/uwp/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) attached properties) and other logic.

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
> For more info, design guidance, and code examples, see [Layout panels](/windows/uwp/design/layout/layout-panels#grid).

Grid is a layout panel that supports arranging child elements in rows and columns.

<img alt="Grid layout panel" src="images/controls/Grid.png" />





You typically define layout behavior for a Grid in XAML by providing one or more [RowDefinition](rowdefinition.md) elements as the value of [Grid.RowDefinitions](grid_rowdefinitions.md), and one or more [ColumnDefinition](columndefinition.md) elements as the value of [Grid.ColumnDefinitions](grid_columndefinitions.md). Then, you apply the [Grid.Row](/uwp/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) and [Grid.Column](/uwp/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) attached properties to each of the element children of the Grid, to indicate which row/column combination is used to position that element within the parent Grid.

To set the height of rows and the width of columns, you set [RowDefinition.Height](rowdefinition_height.md) for each [RowDefinition](rowdefinition.md) and [ColumnDefinition.Width](columndefinition_width.md) for each [ColumnDefinition](columndefinition.md). [ColumnDefinition.Width](columndefinition_width.md) and [RowDefinition.Height](rowdefinition_height.md) are the respective content properties of [ColumnDefinition](columndefinition.md) and [RowDefinition](rowdefinition.md).

By default, each row or column divides layout space equally. You can change this behavior either by providing absolute pixel values, or a **Star** sizing that divides available space using a weighted factor. For more info on how to use **Star** sizing in a Grid, see [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml) or [GridLength](../microsoft.ui.xaml/gridlength.md). You also can use an **Auto** sizing that sizes to content.

Note that there are two ways to define a Grid. If you are simply defining rows and columns *without* using data binding or defining properties such as MinHeight or MaxWidth, you can use the following succinct syntax:

```xaml
<Grid ColumnDefinitions="1*, 2*, Auto, 5"
      RowDefinitions="1*, Auto, 5, 3, 1">

      <!-- Grid content goes here -->

</Grid>
```

If you need to add more details in your Grid definition, such as providing a row's MaxHeight or using data binding in a row/column definition, you should use the original, full-fledged Grid syntax:

```xaml
<Grid>
    <Grid.ColumnDefinitions>
        <ColumnDefinition MaxWidth="30"/>
        <ColumnDefinition Width="*"/>
    </Grid.ColumnDefinitions>
    <Grid.RowDefinitions>
        <RowDefinition Height="{x:Bind RowHeight}"/>
        <RowDefinition Height="{x:Bind RowHeight}"/>
    </Grid.RowDefinitions>

    <!-- Grid content goes here -->

</Grid>
```

To indicate that an element child should span multiple rows or multiple columns in the Grid, you can apply the [Grid.RowSpan](/uwp/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) or [Grid.ColumnSpan](/uwp/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) attached properties to child elements of a Grid.

By default, a Grid contains one row and one column.

Setting the [Margin](../microsoft.ui.xaml/frameworkelement_margin.md) property on the child elements in a Grid sets the distance between the element and its grid cell boundaries. The [HorizontalAlignment](../microsoft.ui.xaml/frameworkelement_horizontalalignment.md) and [VerticalAlignment](../microsoft.ui.xaml/frameworkelement_verticalalignment.md) properties describe how the child element should be positioned within the grid cell. You can precisely position child elements of a Grid by using a combination of the [Margin](../microsoft.ui.xaml/frameworkelement_margin.md) property and alignment properties. If you need even more control over the layout of individual child elements, consider using [VariableSizedWrapGrid](variablesizedwrapgrid.md).

[WrapGrid](wrapgrid.md) is another similar layout panel that has the benefit of better handling for content that's too wide, which might be clipped by a regular Grid depending on values of other layout properties.

An element in the first column that spans multiple rows can affect the height of each spanned row even if the first row has enough height to accommodate the element, and subsequent spanned rows would otherwise have a height of 0. For example, the second row in this Grid has its height set to 0, so the blue rectangle would not typically be visible. In this case, you might expect that the red ellipse would not affect the second row because the first row is tall enough to contain the ellipse. However, the Grid calculates the MinHeight of each row to be enough to accommodate the red ellipse, and then spans the element across the rows. As a result, the second row is given a MinHeight of 50, the red ellipse is centered in the 150px span, and half of the blue rectangle is visible in the second row.

> [!NOTE]
> (This example uses an element that spans columns, but also applies to an element in the first column that spans multiple rows.)


```xaml
<Grid Background="Yellow" Width="300"
      ColumnDefinitions="50, *" RowDefinitions="Auto, 0">
    <Ellipse   Grid.Row="0" Grid.Column="0"  Height="50" Fill="Red" Grid.RowSpan="2"/>
    <Rectangle Grid.Row="0" Grid.Column="1" Fill="Green" Height="100"/>
    <Rectangle Grid.Row="1" Grid.Column="1" Fill="Blue" Height="100"/>
</Grid>
```

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

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | ColumnSpacing |
| 1709 | 16299 | RowSpacing |
| 1809 | 17763 | BackgroundSizing |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/uwp/design/layout/layout-panels#grid).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the Grid in action](xamlcontrolsgallery:/item/Grid).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)


This XAML example shows how to design a layout by using a Grid.


```xml
<Grid x:Name="LayoutRoot" Background="#555555" 
      Width="400" Height="300"
      ColumnDefinitions="250, 150"
      RowDefinitions="Auto, 2*, *">
    <TextBlock Grid.Row="0" Grid.Column="0" 
               Grid.ColumnSpan="2" 
               Margin="10" FontWeight="Bold" 
               Text="Contoso Corporation"
               HorizontalAlignment="Center"
               VerticalAlignment="Center" />
    <Grid x:Name="FormLayoutGrid" Grid.Row="1" Grid.Column="0">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="Auto" />
            <ColumnDefinition />
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
            <RowDefinition Height="*" />
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>
        <TextBlock Grid.Row="0" Grid.Column="0" Text="First Name" Margin="10" 
                   HorizontalAlignment="Left" VerticalAlignment="Center" />
        <TextBox Grid.Row="0" Grid.Column="1" Margin="10" />
        <TextBlock Grid.Row="1" Grid.Column="0" Text="Last Name" Margin="10" 
                   HorizontalAlignment="Left" VerticalAlignment="Center" />
        <TextBox Grid.Row="1" Grid.Column="1" Margin="10" />
        <TextBlock Grid.Row="2" Grid.Column="0" Text="Address" Margin="10" 
                   HorizontalAlignment="Left" VerticalAlignment="Center" />
        <TextBox Grid.Row="2" Grid.Column="1" Margin="10" />
      
    </Grid>
 </Grid>
 ```
C# Code:
```csharp
    public Page()
    {
        InitializeComponent();
        LayoutDesign();
    }

    private void LayoutDesign()
    {
        //Create Stackpanel for ListBox Control and its description
        StackPanel DeptStackPanel = new StackPanel();
        DeptStackPanel.Margin = new Thickness(10);

        LayoutRoot.Children.Add(DeptStackPanel);
        Grid.SetColumn(DeptStackPanel, 1);
        Grid.SetRow(DeptStackPanel, 1);

        TextBlock DeptListHeading = new TextBlock();
        DeptListHeading.Text = "Department";

        ListBox DeptList = new ListBox();
        DeptList.Items.Add("Finance");
        DeptList.Items.Add("Marketing");
        DeptList.Items.Add("Human Resources");
        DeptList.Items.Add("Payroll");

        DeptStackPanel.Children.Add(DeptListHeading);
        DeptStackPanel.Children.Add(DeptList);

        //Create StackPanel for buttons
        StackPanel ButtonsStackPanel = new StackPanel();
        ButtonsStackPanel.Margin = new Thickness(10);
        ButtonsStackPanel.Orientation = Orientation.Horizontal;
        ButtonsStackPanel.HorizontalAlignment = HorizontalAlignment.Center;

        LayoutRoot.Children.Add(ButtonsStackPanel);
        Grid.SetColumn(ButtonsStackPanel, 0);
        Grid.SetRow(ButtonsStackPanel, 2);
        Grid.SetColumnSpan(ButtonsStackPanel, 2);

        Button BackButton = new Button();
        BackButton.Content = "Back";
        BackButton.Width = 100;

        Button CancelButton = new Button();
        CancelButton.Content = "Cancel";
        CancelButton.Width = 100;

        Button NextButton = new Button();
        NextButton.Content = "Next";
        NextButton.Width = 100;

        ButtonsStackPanel.Children.Add(BackButton);
        ButtonsStackPanel.Children.Add(CancelButton);
        ButtonsStackPanel.Children.Add(NextButton);

        BackButton.Margin = new Thickness(10);
        CancelButton.Margin = new Thickness(10);
        NextButton.Margin = new Thickness(10);
    }
}
```

<!-- [!code-xaml[GridClassXAML](../windows.ui.xaml/code/GridReferenceSample/csharp/Page.xaml#SnippetGridClassXAML)]



## -see-also
[Panel](panel.md), [Grid.Row](/uwp/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties), [Grid.Column](/uwp/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties), [Define layouts](/windows/uwp/layout/layouts-with-xaml), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview), [Canvas](canvas.md), [StackPanel](stackpanel.md), [VariableSizedWrapGrid](variablesizedwrapgrid.md), [WrapGrid](wrapgrid.md), [Controls list](/windows/uwp/design/controls-and-patterns/), [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function)
