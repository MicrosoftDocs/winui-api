---
-api-id: M:Microsoft.UI.Xaml.Controls.Frame.NavigateToType(Windows.UI.Xaml.Interop.TypeName,System.Object,Microsoft.UI.Xaml.Navigation.FrameNavigationOptions)
-api-type: winrt method
---

<!-- Method syntax.
public bool Frame.NavigateToType(TypeName sourcePageType, Object parameter, FrameNavigationOptions navigationOptions)
-->

# Microsoft.UI.Xaml.Controls.Frame.NavigateToType

## -description

Causes the [Frame](frame.md) to load content represented by the specified [Page](page.md), also passing a parameter to be interpreted by the target of the navigation.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param sourcePageType

The page to navigate to, specified as a type reference to its partial class type. (A type reference is given as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, or a [TypeName](/uwp/api/windows.ui.xaml.interop.typename) helper struct for Visual C++ component extensions (C++/CX)).

### -param parameter

The navigation parameter to pass to the target page; must have a basic type (string, char, numeric, or [GUID](/windows/win32/api/guiddef/ns-guiddef-guid)) to support parameter serialization using [GetNavigationState](frame_getnavigationstate_1352043812.md).

### -param navigationOptions

Options for the navigation, including whether it is recorded in the navigation stack and what transition animation is used.

## -returns

**false** if a [NavigationFailed](frame_navigationfailed.md) event handler has set [Handled](../microsoft.ui.xaml.navigation/navigationfailedeventargs_handled.md) to **true**; otherwise, **true**.

## -remarks

## -see-also

## -examples

