---
-api-id: T:Microsoft.UI.Xaml.Media.Animation.Transition
-api-type: winrt class
---

<!-- Class syntax.
public class Transition : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.Animation.ITransition
-->

# Microsoft.UI.Xaml.Media.Animation.Transition

## -description
Represents a visual behavior that occurs for predefined actions or state changes. Specific theme transitions (various Transition derived classes) can be applied to individual elements using the [UIElement.Transitions](../microsoft.ui.xaml/uielement_transitions.md) property, or applied for scenario-specific theme transition properties such as [ContentControl.ContentTransitions](../microsoft.ui.xaml.controls/contentcontrol_contenttransitions.md).

## -remarks
### **Transition** derived classes

Transition is the parent class for several immediately derived classes that define library theme transitions. Here are some of the notable derived classes:

+ [AddDeleteThemeTransition](adddeletethemetransition.md)
+ [ContentThemeTransition](contentthemetransition.md)
+ [EdgeUIThemeTransition](edgeuithemetransition.md)
+ [EntranceThemeTransition](entrancethemetransition.md)
+ [PaneThemeTransition](panethemetransition.md)
+ [PopupThemeTransition](popupthemetransition.md)
+ [ReorderThemeTransition](reorderthemetransition.md)
+ [RepositionThemeTransition](repositionthemetransition.md)

For each of these classes, you typically define object elements. Most theme transitions don't have additional attributes, so you typically use a basic self-closing object element, for example `<PopupThemeTransition />`. These are used to populate a [TransitionCollection](transitioncollection.md) property. Those properties include: 

+ [Border.ChildTransitions](../microsoft.ui.xaml.controls/border_childtransitions.md)
+ [ContentControl.ContentTransitions](../microsoft.ui.xaml.controls/contentcontrol_contenttransitions.md)
+ [ContentPresenter.ContentTransitions](../microsoft.ui.xaml.controls/contentpresenter_contenttransitionsproperty.md)
+ [ItemsControl.ItemContainerTransitions](../microsoft.ui.xaml.controls/itemscontrol_itemcontainertransitions.md)
+ [ItemsPresenter.FooterTransitions](../microsoft.ui.xaml.controls/itemspresenter_footertransitions.md)
+ [ItemsPresenter.HeaderTransitions](../microsoft.ui.xaml.controls/itemspresenter_headertransitions.md)
+ [ListViewBase.FooterTransitions](../microsoft.ui.xaml.controls/listviewbase_footertransitions.md)
+ [ListViewBase.HeaderTransitions](../microsoft.ui.xaml.controls/listviewbase_headertransitions.md)
+ [Panel.ChildrenTransitions](../microsoft.ui.xaml.controls/panel_childrentransitions.md)
+ [Popup.ChildTransitions](../microsoft.ui.xaml.controls.primitives/popup_childtransitions.md)
+ [SettingsFlyoutTemplateSettings.ContentTransitions](/uwp/api/windows.ui.xaml.controls.primitives.settingsflyouttemplatesettings.contenttransitions)
+ [UIElement.Transitions](../microsoft.ui.xaml/uielement_transitions.md)


Not all transitions make sense for any given property. For example, [PopupThemeTransition](popupthemetransition.md) is really only useful for [Popup.ChildTransitions](../microsoft.ui.xaml.controls.primitives/popup_childtransitions.md). For more info on how to use the theme transitions, see [Animations overview](/windows/uwp/graphics/animations-overview) and topics linked from there, including the design guidelines topics.

> [!NOTE]
> Prior to Windows 10, version 1809 (SDK 17763), the XAML syntax for properties that have a [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) value requires that you declare an explicit [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) object element as the value, and then provide object elements as child elements of [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) for each of the transition animations you want to use. In Windows 10, version 1809 (SDK 17763) or later, [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) supports the implicit collection usage, so you can omit the collection object element. For more info on implicit collections and XAML, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

## -examples

## -see-also
[DependencyObject](../microsoft.ui.xaml/dependencyobject.md), [Animations overview](/windows/uwp/graphics/animations-overview), [UIElement.Transitions](../microsoft.ui.xaml/uielement_transitions.md)
