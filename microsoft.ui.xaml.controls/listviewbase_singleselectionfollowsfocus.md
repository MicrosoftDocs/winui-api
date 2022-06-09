---
-api-id: P:Microsoft.UI.Xaml.Controls.ListViewBase.SingleSelectionFollowsFocus
-api-type: winrt property
---

<!-- Property syntax
public bool SingleSelectionFollowsFocus { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ListViewBase.SingleSelectionFollowsFocus

## -description
Gets or sets a value that indicates whether item selection changes when keyboard focus changes.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<listViewBase SingleSelectionFollowsFocus="bool" />
```


## -property-value
**true** if item selection changes when keyboard focus changes; otherwise, **false**. The default is **true**.

## -remarks
This property is ignored if the list view's [SelectionMode](listviewbase_selectionmode.md) property is not set to **Single**.

By default, when a list view is configured for single selection, when the user moves keyboard focus to an item, the focused item is also selected. For example, if keyboard focus is moved from the first item to the second item, the [SelectedIndex](../microsoft.ui.xaml.controls.primitives/selector_selectedindex.md) property is updated from 0 to 1.

Set this property to **false** to let a user move focus without the item selection following. For example, if each selection change causes significant UI updates, you might prefer to let the user move focus to a non-adjacent item and then press enter to update selection.

### Version compatibility

The SingleSelectionFollowsFocus property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](/uwp/api/windows.foundation.metadata.apiinformation) class to check for the presence of this property before you set it.

```xaml
<ListView x:Name="listView1" Loaded="ListView_Loaded"/>
```

```csharp
private void ListView_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.ListViewBase", "SingleSelectionFollowsFocus"))
    {
        listView1.SingleSelectionFollowsFocus = false;
    }
}

```



## -examples

## -see-also
