---
-api-id: M:Microsoft.UI.Xaml.DependencyProperty.GetMetadata(Windows.UI.Xaml.Interop.TypeName)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.PropertyMetadata GetMetadata(Windows.UI.Xaml.Interop.TypeName forType)
-->

# Microsoft.UI.Xaml.DependencyProperty.GetMetadata

## -description
Retrieves the property metadata value for the dependency property as registered to a type. You specify the type you want info from as a type reference.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param forType
The name of the specific type from which to retrieve the dependency property metadata, as a type reference ([System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, a [TypeName](/uwp/api/windows.ui.xaml.interop.typename) helper struct for Visual C++ component extensions (C++/CX)).

## -returns
A property metadata object.

## -remarks

## -examples
This example implements a utility method that reports the default value of a given dependency property as it exists in [FrameworkElement](frameworkelement.md), based on the default value registered and stored in the metadata.



[!code-csharp[DPGetMetadata](../microsoft.ui.xaml/code/DOandDP/csharp/Class1.cs#SnippetDPGetMetadata)]

[!code-vb[DPGetMetadata](../microsoft.ui.xaml/code/DOandDP/vbnet/Class1.vb#SnippetDPGetMetadata)]

## -see-also
[Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview)
9e66-f71c-4daa-9994-617c886fda7e)
