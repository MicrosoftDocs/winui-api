---
-api-id: M:Microsoft.UI.Xaml.Controls.INavigate.Navigate(Windows.UI.Xaml.Interop.TypeName)
-api-type: winrt method
---

<!-- Method syntax
public bool Navigate(Windows.UI.Xaml.Interop.TypeName sourcePageType)
-->

# Microsoft.UI.Xaml.Controls.INavigate.Navigate

## -description
Causes the navigation host to load content that is specified by a type reference.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param sourcePageType
A type reference for the content to load.

## -returns
**true** if the navigation host can navigate according to its settings; otherwise, **false**. 
<!--TBW clarify the asynch, that  you probably do not get false just because you specified a source that does not exist, you need async events to tell that.-->

## -remarks
The [INavigate](inavigate.md) interface is mainly infrastructure. It's not expected that typical UWP app will implement this interface.

> [!IMPORTANT]
> If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](/uwp/api/windows.ui.xaml.interop.typename) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true).

## -examples

## -see-also
[Frame.Navigate](frame_navigate_1557370995.md), [HyperlinkButton](hyperlinkbutton.md), [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true)
