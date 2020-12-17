---
-api-id: T:Microsoft.UI.Xaml.Media.Animation.TransitionCollection
-api-type: winrt class
---

<!-- Class syntax.
public class TransitionCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Media.Animation.Transition>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Media.Animation.Transition>
-->

# Microsoft.UI.Xaml.Media.Animation.TransitionCollection

## -description
Represents a collection of [Transition](transition.md) objects. Each [Transition](transition.md) object represents a different theme transition, part of the Windows Runtime animation library.

## -xaml-syntax
```xaml
<TransitionCollection>
    oneOrMoreTransitions
</TransitionCollection>
```


## -remarks
TransitionCollection is used as the value type for these properties:
+ [Border.ChildTransitions](../microsoft.ui.xaml.controls/border_childtransitions.md)
+ [ContentControl.ContentTransitions](../microsoft.ui.xaml.controls/contentcontrol_contenttransitions.md) (on content controls such as [Button](../microsoft.ui.xaml.controls/button.md) or AppBar)
+ [ContentPresenter.ContentTransitions](../microsoft.ui.xaml.controls/contentpresenter_contenttransitionsproperty.md)
+ [ItemsControl.ItemContainerTransitions](../microsoft.ui.xaml.controls/itemscontrol_itemcontainertransitions.md) (on items controls such as [GridView](../microsoft.ui.xaml.controls/gridview.md), [ListBox](../microsoft.ui.xaml.controls/listbox.md), [ListView](../microsoft.ui.xaml.controls/listview.md) and [Selector](../microsoft.ui.xaml.controls.primitives/selector.md))
+ [ItemsPresenter.FooterTransitions](../microsoft.ui.xaml.controls/itemspresenter_footertransitions.md)
+ [ItemsPresenter.HeaderTransitions](../microsoft.ui.xaml.controls/itemspresenter_headertransitions.md)
+ [ListViewBase.FooterTransitions](../microsoft.ui.xaml.controls/listviewbase_footertransitions.md)
+ [ListViewBase.HeaderTransitions](../microsoft.ui.xaml.controls/listviewbase_headertransitions.md)
+ [Panel.ChildrenTransitions](../microsoft.ui.xaml.controls/panel_childrentransitions.md) (on [Grid](../microsoft.ui.xaml.controls/grid.md), [StackPanel](../microsoft.ui.xaml.controls/stackpanel.md) and other panels)
+ [Popup.ChildTransitions](../microsoft.ui.xaml.controls.primitives/popup_childtransitions.md)
+ [SettingsFlyoutTemplateSettings.ContentTransitions](/uwp/api/windows.ui.xaml.controls.primitives.settingsflyouttemplatesettings.contenttransitions)
+ [UIElement.Transitions](../microsoft.ui.xaml/uielement_transitions.md) (on hundreds of classes)

> [!NOTE]
> Prior to Windows 10, version 1809 (SDK 17763), the XAML syntax for properties that have a [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) value requires that you declare an explicit [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) object element as the value, and then provide object elements as child elements of [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) for each of the transition animations you want to use. In Windows 10, version 1809 (SDK 17763) or later, [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) supports the implicit collection usage, so you can omit the collection object element. For more info on implicit collections and XAML, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

Transition animations are preconfigured animations from the Windows Runtime animation library. Transition animations run automatically upon the conditions that the transition animation is associated with, using the property owner where the TransitionCollection is set as the target. The properties being animated vary depending on which transition you use. 
<!--For more info, see Transition animations and theme animations.-->

[VisualStateGroup.Transitions](../microsoft.ui.xaml/visualstategroup_transitions.md) does not use the TransitionCollection type. [VisualStateGroup.Transitions](../microsoft.ui.xaml/visualstategroup_transitions.md) uses a built-in collection(list or vector) of [VisualTransition](../microsoft.ui.xaml/visualtransition.md) objects.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A TransitionCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<Transition>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [Transition](transition.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples
This example shows the XAML syntax for setting a TransitionCollection object element as part of setting the [UIElement.Transitions](../microsoft.ui.xaml/uielement_transitions.md) property inline.



[!code-xaml[EntranceThemeTransitionSimple](../microsoft.ui.xaml.media.animation/code/EntranceThemeTransition/csharp/BlankPage.xaml#SnippetEntranceThemeTransitionSimple)]



[!code-xaml[EntranceThemeTransitionStyle](../microsoft.ui.xaml/code/EntranceThemeTransitionStyle/csharp/BlankPage.xaml#SnippetEntranceThemeTransitionStyle)]

## -see-also
[UIElement.Transitions](../microsoft.ui.xaml/uielement_transitions.md), [ContentControl.ContentTransitions](../microsoft.ui.xaml.controls/contentcontrol_contenttransitions.md), [Panel.ChildrenTransitions](../microsoft.ui.xaml.controls/panel_childrentransitions.md), [IVector&lt;T&gt;](/uwp/api/windows.foundation.collections.ivector`1), [IIterable&lt;T&gt;](/uwp/api/windows.foundation.collections.iiterable`1), [IList<T>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)
d), [IIterable&lt;T&gt;](/uwp/api/windows.foundation.collections.iiterable`1), [IList<T>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)
