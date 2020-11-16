---
-api-id: T:Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo
-api-type: winrt class
---

<!-- Class syntax.
public class NavigationTransitionInfo : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.Animation.INavigationTransitionInfo, Windows.UI.Xaml.Media.Animation.INavigationTransitionInfoOverrides
-->

# Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo

## -description
Provides parameter info for the [Frame.Navigate](/uwp/api/windows.ui.xaml.controls.frame.navigate(windows.ui.xaml.interop.typename,system.object,windows.ui.xaml.media.animation.navigationtransitioninfo)) method. Controls how the transition animation runs during the navigation action.

## -remarks
Navigation transition animations can be any of the *TransitionInfo types. For UWP apps, we recommend using the following page transitions:
- [EntranceNavigationTransitionInfo](entrancenavigationtransitioninfo.md)
- [DrillInNavigationTransitionInfo](drillinnavigationtransitioninfo.md)
- [SuppressNavigationTransitionInfo](suppressnavigationtransitioninfo.md)

> For Windows Phone 8.x apps, several derived types ([CommonNavigationTransitionInfo](commonnavigationtransitioninfo.md), [ContinuumNavigationTransitionInfo](continuumnavigationtransitioninfo.md), [SlideNavigationTransitionInfo](slidenavigationtransitioninfo.md)) can be used in XAML to fill the [NavigationThemeTransition.DefaultNavigationTransitionInfo](navigationthemetransition_defaultnavigationtransitioninfo.md) property.

## -examples
```xaml
<Frame x:Name="myFrame">
    <Frame.ContentTransitions>
        <TransitionCollection>
            <NavigationThemeTransition />
        </TransitionCollection>
    </Frame.ContentTransitions>
</Frame>
```

```csharp
// Play the default animation
myFrame.Navigate(typeof(Page2), null);

// Explicitly play the page refresh animation
myFrame.Navigate(typeof(Page2), null, new EntranceNavigationTransitionInfo());

// Play the drill in animation
myFrame.Navigate(typeof(Page2), null, new DrillInNavigationTransitionInfo());

// Suppress the default animation
myFrame.Navigate(typeof(Page2), null, new SuppressNavigationTransitionInfo());
```


## -see-also
[DependencyObject](../microsoft.ui.xaml/dependencyobject.md), [Frame.Navigate](/uwp/api/windows.ui.xaml.controls.frame.navigate)
