---
-api-id: P:Microsoft.UI.Xaml.Markup.IXamlType.UnderlyingType
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Interop.TypeName UnderlyingType { get; }
-->

# Microsoft.UI.Xaml.Markup.IXamlType.UnderlyingType

## -description
Gets information for the backing type.

## -property-value
The backing type as represented by the relevant type system or interop support type. This is a type reference ([System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, a [TypeName](/uwp/api/windows.ui.xaml.interop.typename) helper struct for Visual C++ component extensions (C++/CX)).

## -remarks
> [!NOTE]
> If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](/uwp/api/windows.ui.xaml.interop.typename) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). If you're using Visual C++ component extensions (C++/CX)), this is a [TypeName](/uwp/api/windows.ui.xaml.interop.typename) helper struct.

## -examples

## -see-also
[TypeName](/uwp/api/windows.ui.xaml.interop.typename)
