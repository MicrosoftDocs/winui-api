---
-api-id: P:Microsoft.UI.Xaml.Controls.Image.Stretch
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Stretch Stretch { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Image.Stretch

## -description
Gets or sets a value that describes how an [Image](image.md) should be stretched to fill the destination rectangle.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Image Stretch="stretchValue"/>
```


## -xaml-values
<dl><dt>stretchValue</dt><dd>stretchValueA named constant of the Stretch enumeration, such as Uniform.</dd>
</dl>
## -property-value
A value of the [Stretch](../microsoft.ui.xaml.media/stretch.md) enumeration that specifies how the source image is rendered, if the [Height](../microsoft.ui.xaml/frameworkelement_height.md) and/or [Width](../microsoft.ui.xaml/frameworkelement_width.md) of the [Image](image.md) are not explicitly specified. The default value is **Uniform**.

## -remarks
The value of the Stretch property is only relevant if the [Image](image.md) instance is not already using explicitly set values for the [Height](../microsoft.ui.xaml/frameworkelement_height.md) and/or [Width](../microsoft.ui.xaml/frameworkelement_width.md) property, and if the [Image](image.md) instance is inside a container that can stretch the image to fill some available space in layout. If you set the value of the Stretch property to **None**, the image always retains its natural size, even if there's a layout container that might stretch it otherwise. For more info on image sizing, see Remarks in [Image](image.md).

### Image sources and scaling

You should create your image sources at several recommended sizes, to ensure that your app looks great when Windows scales it because of device scaling and resolution. This is often a better way to handling image resizing rather than applying a nondefault Stretch value. When specifying a [Source](image_source.md) for an [Image](image.md), you can use a naming convention that will automatically reference the correct resource for the current scaling. For specifics of the naming convention and more info, see [Load images and assets tailored for scale](/windows/uwp/app-resources/images-tailored-for-scale-theme-contrast).

For more info on how to design for scaling, see [Introduction to Windows app design](/windows/apps/design/basics/design-and-ui-intro).

> [!NOTE]
> A Stretch value of **None** doesn't work for image resources that are intended to support scaling. The scaling will be detected and the appropriate scaled resource is loaded before the layout decisions implied by the **None** value are applied.

## -examples

## -see-also
