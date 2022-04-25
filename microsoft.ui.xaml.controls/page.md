---
-api-id: T:Microsoft.UI.Xaml.Controls.Page
-api-type: winrt class
---

<!-- Class syntax.
public class Page : Windows.UI.Xaml.Controls.UserControl, Windows.UI.Xaml.Controls.IPage, Windows.UI.Xaml.Controls.IPageOverrides
-->

# Microsoft.UI.Xaml.Controls.Page

## -description
Represents content that a [Frame](frame.md) control can navigate to.

## -xaml-syntax
```xaml
<Page .../>
-or-
<Page ...>
  singleRootElement
</Page>
```

## -remarks
The Page class encapsulates content that the [Frame](frame.md) control can navigate to. You will generally create your own page types that derive from the Page class, and use Page (or a custom type) as the root element for the XAML-declared content.

Page is a [UserControl](usercontrol.md), therefore you can declare a single XAML object element as [Content](usercontrol_content.md) for the Page. Most pages contain more than one UI element in total. You typically use a panel or items control as the immediate child of a Page, so that you can have the page contain and compose multiple elements of a UI.

You can also specify app bars, with the [TopAppBar](page_topappbar.md) and [BottomAppBar](page_bottomappbar.md) properties. You must use property element syntax for these properties to contain the [AppBar](appbar.md) values in XAML.

You can create new pages using the **Add | New Item** menu option for your project in Microsoft Visual Studio. These all create XAML files where the root is a Page class, and the code-behind class derives from Page. Some page item templates add navigation support and additional features. For more info on the Microsoft Visual Studio item templates, see [C#, VB, and C++ item templates for ](/previous-versions/windows/apps/jj236469(v=win.10)).

Create as many pages as you need to present the content in your app, and then navigate to those pages by calling the [Frame.Navigate](frame_navigate_1557370995.md) method and passing in a type reference for the page to navigate to. By type reference, we mean an instance of a class that identifies a type in the type system, for the language you are using. For Microsoft .NET that type is [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true), and you can get a [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) reference from a page class' name by using the operators **typeof** (C#) or **GetType** (Visual Basic). For Visual C++ component extensions (C++/CX), use [TypeName](/uwp/api/windows.ui.xaml.interop.typename). Initialize a [TypeName](/uwp/api/windows.ui.xaml.interop.typename) by using the **typeid** of a class. **typeid** is a component extension that can be called for any runtime class.

Through [Frame.Navigate](frame_navigate_1557370995.md), you can also pass in a parameter object to initialize the page to a particular state. The parameter object is loosely typed but serialization of navigation history only works for basic types (see Remarks in [Frame.Navigate(Type, Object)](frame_navigate_1603787821.md)). Pages that are navigated to as part of an activation generally pass data from the activation. Other navigation scenarios such as search result pages also have expectations of what info will be contained in the parameter.

By default, each navigation creates a new instance of the specific Page (or subclass) requested, and disposes the previous page instance. This happens even when navigating back to a previously visited page or when the new page type is the same as the previous page type. Apps that involve frequent navigation to the same pages can cache and reuse the page instances to make navigation more efficient. To do this, set the [Frame.CacheSize](frame_cachesize.md) property to specify how many pages to cache. For each page type that you want to cache, you must also set the [NavigationCacheMode](page_navigationcachemode.md) property to either **Enabled** or **Required**. Pages with a **Required** cache mode are cached regardless of the [CacheSize](frame_cachesize.md) value, and do not count against the [CacheSize](frame_cachesize.md) total.

You can override the page [OnNavigatedTo](page_onnavigatedto_1316593960.md), [OnNavigatingFrom](page_onnavigatingfrom_1820075439.md), and [OnNavigatedFrom](page_onnavigatedfrom_1545714785.md) methods to perform tasks such as initializing and saving the page state. [OnNavigatingFrom](page_onnavigatingfrom_1820075439.md) can be used to cancel a navigation by setting a [Cancel](../microsoft.ui.xaml.navigation/navigatingcanceleventargs_cancel.md) property in the event data from your handler.

## -examples

These steps outline how to add a **Page** to a WinUI 3 project, and navigate to it.

1. In Visual Studio, create a new C# project from the **Blank App, Packaged (WinUI 3 in Desktop)** project template. Add a new item to the project (**WinUI** > **Blank Page (WinUI 3)**) named `MainPage.xaml`.

1. Then, in `App.xaml.cs`, edit the [OnLaunched](/windows/winui/api/microsoft.ui.xaml.application.onlaunched) method override so that it looks like the code listing below. The code shows how the content of the app's main window is set to a new [Frame](frame.md), which is then navigated to the **MainPage** that you just added.

```csharp
protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
{
    m_window = new MainWindow();

    // Create a Frame to act as the navigation context.
    Frame rootFrame = new Frame();

    rootFrame.NavigationFailed += OnNavigationFailed;

    // Place the frame in the current Window
    m_window.Content = rootFrame;

    rootFrame.Navigate(typeof(MainPage), args.Arguments);

    m_window.Activate();
}
```

For example code that adds an [AppBar](appbar.md) to a page, see [Quickstart: adding app bars](/previous-versions/windows/apps/hh781230(v=win.10)) or [How to share an app bar across pages](/previous-versions/windows/apps/jj150604(v=win.10)). For example code that uses [NavigationCacheMode](page_navigationcachemode.md), see [Navigation](/windows/uwp/layout/navigation-basics) or [XAML Navigation sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlNavigation).

## -see-also
[Frame](frame.md), [UserControl](usercontrol.md), [Quickstart: adding app bars](/previous-versions/windows/apps/hh781230(v=win.10)), [Navigation design basics overview](/windows/apps/design/basics/navigation-basics), [XAML Navigation sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlNavigation)
