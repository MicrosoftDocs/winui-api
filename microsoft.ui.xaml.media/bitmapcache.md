---
-api-id: T:Microsoft.UI.Xaml.Media.BitmapCache
-api-type: winrt class
---

<!-- Class syntax.
public class BitmapCache : Windows.UI.Xaml.Media.CacheMode, Windows.UI.Xaml.Media.IBitmapCache
-->

# Microsoft.UI.Xaml.Media.BitmapCache

## -description
Represents the behavior of caching a visual element or tree of elements as bitmap surfaces.

## -remarks
This class is infrastructure, and provides the underlying run-time value for the behavior when you specify `CacheMode="BitmapCache"` in XAML markup, or create a new BitmapCache in code to set [UIElement.CacheMode](../microsoft.ui.xaml/uielement_cachemode.md).

## -examples
Use any of these syntax forms to set [UIElement.CacheMode](../microsoft.ui.xaml/uielement_cachemode.md) to a value other than the **null** default. Don't do this routinely without testing first, see "Remarks" in [UIElement.CacheMode](../microsoft.ui.xaml/uielement_cachemode.md).

```xaml
<Canvas CacheMode="BitmapCache">
  ...
</Canvas>
```

```csharp
canvas1.CacheMode = new BitmapCache(); //canvas1 is an existing named element in UI
```

```cppwinrt
// <Canvas x:Name="canvas1"/>
#include <winrt/Windows.UI.Xaml.Media.h>
...
canvas1().CacheMode(Windows::UI::Xaml::Media::BitmapCache{});
```

```cppcx
canvas1->CacheMode = ref new BitmapCache(); //canvas1 is an existing named element in UI
```

## -see-also
[UIElement.CacheMode](../microsoft.ui.xaml/uielement_cachemode.md), [IsOverdrawHeatMapEnabled](/uwp/api/windows.ui.xaml.debugsettings.isoverdrawheatmapenabled), [Optimize your XAML markup](/windows/uwp/debug-test-perf/optimize-xaml-loading)
