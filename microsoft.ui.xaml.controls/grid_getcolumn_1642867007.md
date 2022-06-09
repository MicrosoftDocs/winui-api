---
-api-id: M:Microsoft.UI.Xaml.Controls.Grid.GetColumn(Microsoft.UI.Xaml.FrameworkElement)
-api-type: winrt method
---

<!-- Method syntax
public int GetColumn(Windows.UI.Xaml.FrameworkElement element)
-->

# Microsoft.UI.Xaml.Controls.Grid.GetColumn

## -description
Gets the value of the [Grid.Column](/windows/winui/api/microsoft.ui.xaml.controls.grid**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

#xaml-attached-properties) XAML attached property from the specified [FrameworkElement](../microsoft.ui.xaml/frameworkelement.md).

## -parameters
### -param element
The element from which to read the property value.

## -returns
The value of the [Grid.Column](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) XAML attached property on the target element. This is a zero-based index.

## -remarks
This method is a utility method for the property system, and isn't used in most app scenarios. In most cases you set the [Grid.Column](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) XAML attached property in XAML and won't need this method. For more info, see the [Grid.Column](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) XAML attached property.

## -examples
The following example shows how to get the row and column of the element that raised an event.


<!--   <p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=GridGetSet</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>
 -->



[!code-xaml[1](../microsoft.ui.xaml.controls.primitives/code/GridGetSet/csharp/Page.xaml#Snippet1)]

[!code-csharp[2](../microsoft.ui.xaml.controls.primitives/code/GridGetSet/csharp/Page.xaml.cs#Snippet2)]
<!--     <desc><p xml:space="preserve">The preceding example produces output that is similar to the following illustration.</p>
      <TRANSLATE_MANUALLY>
        <mediaLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
          <image p8:href="25325562-3a82-4c66-97e9-3a7330b6a835" xmlns:p8="http://www.w3.org/1999/xlink"/>
        </mediaLink>
      </TRANSLATE_MANUALLY></desc>
 -->

## -see-also
[Grid.Column](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties)
