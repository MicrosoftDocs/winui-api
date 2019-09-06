---
-api-id: E:Microsoft.UI.Xaml.Controls.TabView.TabCloseRequested
-api-type: winrt event
---

## -description

Raised when the user attempts to close a Tab via clicking the x-to-close button, CTRL+F4, or mousewheel.

## -remarks

Use this event to close the requested tab by either removing it from the TabItems collection or from the collection of data items. 

## -see-also

## -examples

``` xml
<TabView TabCloseRequested="Tabs_TabCloseRequested" />
```

``` csharp
// Remove the requested tab from the TabView
private void Tabs_TabCloseRequested(TabView sender, TabViewTabCloseRequestedEventArgs args)
{
    sender.TabItems.Remove(args.Tab);
}
```

