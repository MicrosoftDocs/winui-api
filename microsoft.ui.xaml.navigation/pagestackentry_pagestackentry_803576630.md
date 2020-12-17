---
-api-id: M:Microsoft.UI.Xaml.Navigation.PageStackEntry.#ctor(Windows.UI.Xaml.Interop.TypeName,System.Object,Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo)
-api-type: winrt constructor
---

<!-- Method syntax
public PageStackEntry(Windows.UI.Xaml.Interop.TypeName sourcePageType, System.Object parameter, Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo navigationTransitionInfo)
-->

# Microsoft.UI.Xaml.Navigation.PageStackEntry.PageStackEntry

## -description
Initializes a new instance of the [PageStackEntry](pagestackentry.md) class.

## -parameters
### -param sourcePageType
The type of page associated with the navigation entry, as a type reference ([System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, a [TypeName](/uwp/api/windows.ui.xaml.interop.typename) helper struct for Visual C++ component extensions (C++/CX)).

### -param parameter
The navigation parameter associated with the navigation entry.

### -param navigationTransitionInfo
Info about the animated transition associated with the navigation entry.

## -remarks
> [!NOTE]
> If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](/uwp/api/windows.ui.xaml.interop.typename) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). When programming using C#, it is common to use the **typeof** operator to get references to the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) of a type. In Microsoft Visual Basic, use **GetType**. If you're using Visual C++ component extensions (C++/CX)), where you'll need to create a [TypeName](/uwp/api/windows.ui.xaml.interop.typename) helper struct, you can use the [typeid component extension](/cpp/windows/typeid-cpp-component-extensions).

## -examples

## -see-also
[BackStack](../microsoft.ui.xaml.controls/frame_backstack.md), [ForwardStack](../microsoft.ui.xaml.controls/frame_forwardstack.md), [XAML Navigation sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlNavigation)
