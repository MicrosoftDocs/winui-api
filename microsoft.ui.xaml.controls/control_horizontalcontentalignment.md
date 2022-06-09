---
-api-id: P:Microsoft.UI.Xaml.Controls.Control.HorizontalContentAlignment
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.HorizontalAlignment HorizontalContentAlignment { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Control.HorizontalContentAlignment

## -description
Gets or sets the horizontal alignment of the control's content.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<control HorizontalContentAlignment="horizontalAlignmentMemberName"/>
```


## -xaml-values
<dl><dt>horizontalAlignmentMemberName</dt><dd>horizontalAlignmentMemberNameA named constant of the HorizontalAlignment enumeration, such as Stretch.</dd>
</dl>
## -property-value
One of the [HorizontalAlignment](../microsoft.ui.xaml/horizontalalignment.md) values. The default is **Left**.

## -remarks
Each control might apply this property differently based on the [Style](../microsoft.ui.xaml/style.md) setters for the control's implicit style, and its visual template. Also, the apparent "default value" of each individual control used in UI can be different. For example, a [Button](button.md) control starts with the value **Center**.

A value for the HorizontalContentAlignment property only affects layout behavior for a control when its template uses the HorizontalContentAlignment property as the source of a [HorizontalAlignment](../microsoft.ui.xaml/frameworkelement_horizontalalignment.md) value for presenters or content areas within. On other controls, setting HorizontalContentAlignment has no effect. For more info about visual templates for controls, see the reference for [Control.Template](control_template.md).
<!--link to TBW Styles and Templates overview-->

## -examples

## -see-also
[VerticalContentAlignment](control_verticalcontentalignment.md), [FrameworkElement.HorizontalAlignment](../microsoft.ui.xaml/frameworkelement_horizontalalignment.md), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding)
