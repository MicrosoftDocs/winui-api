---
-api-id: T:Microsoft.UI.Xaml.Media.Animation.NavigationThemeTransition
-api-type: winrt class
---

<!-- Class syntax.
public class NavigationThemeTransition : Windows.UI.Xaml.Media.Animation.Transition, Windows.UI.Xaml.Media.Animation.INavigationThemeTransition
-->

# Microsoft.UI.Xaml.Media.Animation.NavigationThemeTransition

## -description

Provides page navigation animations.

## -xaml-syntax

```xaml
<NavigationThemeTransition .../>
```

## -remarks

With Windows 10, version 1803, a Frame uses **NavigationThemeTransition** to animate navigation between Pages by default. 

You can use NavigationThemeTransition to add animated transitions when your app navigates between different pieces of content in a [Frame](../microsoft.ui.xaml.controls/frame.md). You can add NavigationThemeTransition to the [Transitions](../microsoft.ui.xaml/uielement_transitions.md) collection of the [Page](../microsoft.ui.xaml.controls/page.md) that is being navigated to, or the [ContentTransitions](../microsoft.ui.xaml.controls/contentcontrol_contenttransitions.md) collection for the navigation [Frame](../microsoft.ui.xaml.controls/frame.md). In general, we recommend that you use the frame's [ContentTransitions](../microsoft.ui.xaml.controls/contentcontrol_contenttransitions.md) property to ensure that transitions occur for all navigation pages.

This example shows NavigationThemeTransition added to the [ContentTransitions](../microsoft.ui.xaml.controls/contentcontrol_contenttransitions.md) collection of a [Frame](../microsoft.ui.xaml.controls/frame.md).

```xaml
<Frame ...>
    <Frame.ContentTransitions>
        <TransitionCollection>
            <NavigationThemeTransition/> 
        </TransitionCollection> 
    </Frame.ContentTransitions> 
    ...
</Frame> 

```

```csharp
var frame = new Frame(); 
frame.ContentTransitions = new TransitionCollection(); 
frame.ContentTransitions.Add(new NavigationThemeTransition()); 

```

In Windows 10, two different animations are provided for navigation between pages in an app. The navigation animations are represented by subclasses of [NavigationTransitionInfo](navigationtransitioninfo.md).

+ *Page Refresh*: Page refresh is the default animation for page navigation. It is a combination of a *slide up* animation and a *fade in* animation for the incoming content. You should use page refresh when you use top level navigation like a navigation menu.

The page refresh animation is represented by the [EntranceNavigationTransitionInfo](entrancenavigationtransitioninfo.md) class. You can use the [EntranceNavigationTransitionInfo.IsTargetElement](/windows/winui/api/microsoft.ui.xaml.media.animation.entrancenavigationtransitioninfo#xaml-attached-properties) attached property to apply the page refresh motion to a subset of the page; for example, all content excluding the commanding UI of the page.

+ *Drill In*: You should use the drill in animation when a user interacts with UI on a page that represents a link to another page. For example, in a page that represents a list of albums, when a user clicks on an album item, there should be a drill in transition to the album page.

The drill in animation is represented by the [DrillInNavigationTransitionInfo](drillinnavigationtransitioninfo.md) class.

By default, NavigationThemeTransition plays a page refresh animation. However, you can override this behavior by setting the [DefaultNavigationTransitionInfo](navigationthemetransition_defaultnavigationtransitioninfo.md) property of NavigationThemeTransition. The [NavigationTransitionInfo](navigationtransitioninfo.md) value of this property is used for all navigation by default.

You can specify the animation to use for a particular navigation by using the overload of [Frame.Navigate](/uwp/api/windows.ui.xaml.controls.frame.navigate(windows.ui.xaml.interop.typename,system.object,windows.ui.xaml.media.animation.navigationtransitioninfo)) that takes 3 parameters.

In this example, when a user "drills in" from an album list to a page representing a particular album, a music browsing app requests a drill in animation.

```csharp
void AlbumsListView_ItemClick(object sender, ItemClickEventArgs e) 
{
    // Get albumId from clicked item... 
    Frame.Navigate(typeof(AlbumPage), albumId, new DrillInNavigationTransitionInfo());
} 

```

In addition, you can use the [Frame.GoBack(NavigationTransitionInfo)](/uwp/api/windows.ui.xaml.controls.frame.goback(windows.ui.xaml.media.animation.navigationtransitioninfo)) to play a specific transition when navigating back in the [Frame](../microsoft.ui.xaml.controls/frame.md) back stack. This can be useful when you modify navigation behavior dynamically based on screen size; for example, in a responsive master/detail scenario. For more examples, see the [XAML master/detail sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlMasterDetail).

### SuppressNavigationTransitionInfo

You can use [SuppressNavigationTransitionInfo](suppressnavigationtransitioninfo.md) in the place of other [NavigationTransitionInfo](navigationtransitioninfo.md) subtypes when you want to avoid playing any animation during navigation.

```csharp
// Navigate to your first page without a transition 
Frame.Navigate(typeof(MainPage), null, new SuppressNavigationTransitionInfo()); 

```

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Page transitions](/windows/apps/design/motion/page-transitions).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/PageTransitions) or [**WinUI 2 Gallery**](winui2gallery:/item/PageTransitions).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


## -see-also

[Transition](transition.md), [EntranceNavigationTransitionInfo](entrancenavigationtransitioninfo.md), [DrillInNavigationTransitionInfo](drillinnavigationtransitioninfo.md), [SuppressNavigationTransitionInfo](suppressnavigationtransitioninfo.md), [Frame.Navigate(Type, object, NavigationTransitionInfo)](/uwp/api/windows.ui.xaml.controls.frame.navigate(windows.ui.xaml.interop.typename,system.object,windows.ui.xaml.media.animation.navigationtransitioninfo)), [Frame.GoBack(NavigationTransitionInfo)](/uwp/api/windows.ui.xaml.controls.frame.goback(windows.ui.xaml.media.animation.navigationtransitioninfo)), [XAML Master/detail sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlMasterDetail)
