---
-api-id: T:Microsoft.UI.Xaml.Media.Animation.DrillInNavigationTransitionInfo
-api-type: winrt class
---

<!-- Class syntax.
public class DrillInNavigationTransitionInfo : Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo, Windows.UI.Xaml.Media.Animation.IDrillInNavigationTransitionInfo
-->

# Microsoft.UI.Xaml.Media.Animation.DrillInNavigationTransitionInfo

## -description
Specifies the animation to run when a user navigates forward in a logical hierarchy, like from a master list to a detail page.

## -remarks

## -examples

In this example, when a user "drills in" from an album list to a page representing a particular album, a music browsing app requests a drill in animation.

```csharp
void AlbumsListView_ItemClick(object sender, ItemClickEventArgs e) 
{
    // Get albumId from clicked item... 
    Frame.Navigate(typeof(AlbumPage), albumId, new DrillInNavigationTransitionInfo());
} 

```

## -see-also
[NavigationTransitionInfo](navigationtransitioninfo.md), [Frame.Navigate(Type, Object, NavigationTransitionInfo)](/uwp/api/windows.ui.xaml.controls.frame.navigate(windows.ui.xaml.interop.typename,system.object,windows.ui.xaml.media.animation.navigationtransitioninfo))
