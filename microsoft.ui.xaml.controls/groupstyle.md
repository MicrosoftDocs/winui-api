---
-api-id: T:Microsoft.UI.Xaml.Controls.GroupStyle
-api-type: winrt class
---

<!-- Class syntax.
public class GroupStyle : Windows.UI.Xaml.Controls.IGroupStyle, Windows.UI.Xaml.Controls.IGroupStyle2, Windows.UI.Xaml.Data.INotifyPropertyChanged
-->

# Microsoft.UI.Xaml.Controls.GroupStyle

## -description
Describes how to display the grouped items in a collection, such as the collection from [GroupItems](../microsoft.ui.xaml.data/icollectionviewgroup_groupitems.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<GroupStyle />
```


## -remarks
A GroupStyle is typically defined in Extensible Application Markup Language (XAML) and then set as the value of the [ItemsControl.GroupStyle](itemscontrol_groupstyle.md) property to define the visual look of the groups.

## -examples
Here, a GroupStyle is applied to a [GridView](gridview.md) control that contains grouped data. For more info, and to see the full example code, see [How to group items in a list or grid](/previous-versions/windows/apps/hh780627(v=win.10)).



[!code-xaml[GroupedGridViewXAML](../microsoft.ui.xaml.controls/code/ItemsControlGroupingSnippets/csharp/MainPage.xaml#SnippetGroupedGridViewXAML)]

## -see-also
[ItemsControl.GroupStyle](itemscontrol_groupstyle.md), [GroupItem](groupitem.md), [INotifyPropertyChanged](../microsoft.ui.xaml.data/inotifypropertychanged.md), [How to group items in a list or grid](/previous-versions/windows/apps/hh780627(v=win.10))
