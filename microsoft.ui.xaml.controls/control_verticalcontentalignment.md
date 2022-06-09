---
-api-id: P:Microsoft.UI.Xaml.Controls.Control.VerticalContentAlignment
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.VerticalAlignment VerticalContentAlignment { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Control.VerticalContentAlignment

## -description
Gets or sets the vertical alignment of the control's content.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<control VerticalContentAlignment="verticalAlignmentValue"/>
```


## -xaml-values
<dl><dt>verticalAlignmentValue</dt><dd>verticalAlignmentValueA named constant of the VerticalAlignment enumeration, such as Stretch.</dd>
</dl>
## -property-value
One of the [VerticalAlignment](../microsoft.ui.xaml/verticalalignment.md) values. The default is **Top**.

## -remarks
Each control might apply this property differently based on the [Style](../microsoft.ui.xaml/style.md) setters for the control's implicit style, and its visual template. Also, the apparent "default value" of each individual control used in UI can be different. For example, a [Button](button.md) control starts with the value **Center**.

A value for the VerticalContentAlignment property only affects layout behavior for a control when its template uses the VerticalContentAlignment property as the source of a [VerticalAlignment](../microsoft.ui.xaml/frameworkelement_verticalalignment.md) value for presenters or content areas within. On other controls, setting VerticalContentAlignment has no effect. For more info about visual templates for controls, see the reference for [Control.Template](control_template.md).
<!--link to TBW Styles and Templates overview-->

## -examples

## -see-also
[HorizontalContentAlignment](control_horizontalcontentalignment.md), [FrameworkElement.VerticalAlignment](../microsoft.ui.xaml/frameworkelement_verticalalignment.md), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding)
