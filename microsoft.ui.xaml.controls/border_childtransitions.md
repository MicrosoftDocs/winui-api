---
-api-id: P:Microsoft.UI.Xaml.Controls.Border.ChildTransitions
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.TransitionCollection ChildTransitions { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Border.ChildTransitions

## -description
Gets or sets the collection of [Transition](../microsoft.ui.xaml.media.animation/transition.md) style elements that apply to child content of a [Border](border.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<Border>
  <Border.ChildTransitions>
    <TransitionCollection>
      oneOrMoreTransitions
    </TransitionCollection>
  </Border.ChildTransitions>
</Border>
```


## -xaml-values
<dl><dt>oneOrMoreTransitions</dt><dd>oneOrMoreTransitionsOne or more object elements instantiating types that are derived from the Transition base type. Typically there is only one of each type of transition included in the collection.</dd>
</dl>
## -property-value
The strongly typed collection of [Transition](../microsoft.ui.xaml.media.animation/transition.md) style elements.

## -remarks

> [!NOTE]
> Prior to Windows 10, version 1809 (SDK 17763), the XAML syntax for properties that have a [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) value requires that you declare an explicit [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) object element as the value, and then provide object elements as child elements of [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) for each of the transition animations you want to use. In Windows 10, version 1809 (SDK 17763) or later, [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) supports the implicit collection usage, so you can omit the collection object element. For more info on implicit collections and XAML, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

Transition animations play a particular role in the UI design of your app. The basic idea is that when there is a change or transition, the animation draws the attention of the user to the change.

It's not common to set the value of the ChildTransitions property directly on a [Border](border.md) that is a direct element of app UI. It's more common to have a transitions collection be a part of a visual state, template or style. In this case you use mechanisms such as [Setter](../microsoft.ui.xaml/setter.md) of a [Style](../microsoft.ui.xaml/style.md) to specify the ChildTransitions property. Styles are typically stored as a XAML resource.

## -examples

## -see-also
[TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md)
