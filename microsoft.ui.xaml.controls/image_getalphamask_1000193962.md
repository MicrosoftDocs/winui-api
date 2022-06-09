---
-api-id: M:Microsoft.UI.Xaml.Controls.Image.GetAlphaMask
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Composition.CompositionBrush GetAlphaMask()
-->

# Microsoft.UI.Xaml.Controls.Image.GetAlphaMask

## -description
Returns a mask that represents the alpha channel of an image as a [CompositionBrush](../microsoft.ui.composition/compositionbrush.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -returns
A mask that represents the alpha channel of an image.

## -remarks
This method gets an alpha mask from an image as a [CompositionBrush](../microsoft.ui.composition/compositionbrush.md) that you can use as an input to composition shadows and effects. The alpha mask [CompositionBrush](../microsoft.ui.composition/compositionbrush.md) has the same alignment and stretch property values that the source XAML element applies to its rendered content so that you can use those values to correctly position shadows or effects relative to the XAML element.

### Version compatibility

The GetAlphaMask method is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not call this method without first performing a runtime check. This example shows how to use the [ApiInformation](/uwp/api/windows.foundation.metadata.apiinformation) class to check for the presence of this method before you use it.

```csharp
if (ApiInformation.IsMethodPresent("Windows.UI.Xaml.Controls.Image", "GetAlphaMask"))
{
    var compositionBrush = image1.GetAlphaMask();
}

```



## -examples

## -see-also
