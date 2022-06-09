---
-api-id: P:Microsoft.UI.Xaml.Controls.Grid.ColumnDefinitions
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ColumnDefinitionCollection ColumnDefinitions { get; }
-->

# Microsoft.UI.Xaml.Controls.Grid.ColumnDefinitions

## -description

Gets a list of [ColumnDefinition](columndefinition.md) objects defined on this instance of [Grid](grid.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<Grid>
  <Grid.ColumnDefinitions>
    oneOrMoreColumnDefinitions
  </Grid.ColumnDefinitions>
</Grid>
```

## -xaml-values
<dl><dt>oneOrMoreColumnDefinitions</dt><dd>oneOrMoreColumnDefinitionsOne or more ColumnDefinition elements. Each such ColumnDefinition becomes a placeholder representing a column in the final grid layout.</dd>
</dl>

## -property-value

A list of [ColumnDefinition](columndefinition.md) objects defined on this instance of [Grid](grid.md).

## -remarks

## -examples

The following example creates a [Grid](grid.md) with two columns by using [Microsoft.UI.Xaml.Controls.Grid.ColumnDefinitions](grid_columndefinitions.md) [ColumnDefinition](columndefinition.md)s. You can do this using the new succinct syntax or the original syntax - both are accurate and produce the equivalent result. See examples of both below:

Using new succinct syntax:

[!code-xaml[ColumnDefNewSyntaxSample](../microsoft.ui.xaml.controls/code/UpdatedGridSamples/MainPage.xaml#SnippetColumnDefNewSyntaxSample)]

Using the original syntax:

[!code-xaml[ColumnDefOldSyntaxSample](../microsoft.ui.xaml.controls/code/UpdatedGridSamples/MainPage.xaml#SnippetColumnDefOldSyntaxSample)]

## -see-also

[RowDefinitions](grid_rowdefinitions.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
