---
-api-id: P:Microsoft.UI.Xaml.Controls.ContentPresenter.ContentTransitions
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.TransitionCollection ContentTransitions { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ContentPresenter.ContentTransitions

## -description
Gets or sets the collection of [Transition](../microsoft.ui.xaml.media.animation/transition.md) style elements that apply to content presented by the [ContentPresenter](contentpresenter.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<contentPresenter>
  <contentPresenter.ContentTransitions>
    <TransitionCollection>
      oneOrMoreTransitions
    </TransitionCollection>
  </contentPresenter.ContentTransitions>
</contentPresenter>
```


## -xaml-values
<dl><dt>oneOrMoreTransitions</dt><dd>oneOrMoreTransitionsOne or more object elements instantiating types that are derived from the Transition base type.</dd>
</dl>
## -property-value
The strongly typed collection of [Transition](../microsoft.ui.xaml.media.animation/transition.md) style elements.

## -remarks
> [!IMPORTANT]
> The XAML syntax for all properties that use a [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) value is unusual in that you must declare an explicit [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) object element as the value, and then provide object elements as child elements of [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) for each of the transition animations you want to use. For most other XAML collection properties you could omit the collection object element because it can be implicit, but properties that use [TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md) don't support the implicit collection usage. For more info on implicit collections and XAML, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

Transition animations play a particular role in UI design of your app. The basic idea is that when there is a change or transition, the animation draws the attention of the user to the change.
<!-- For more info, see  Transition animations and theme animations.-->

## -examples

## -see-also
[TransitionCollection](../microsoft.ui.xaml.media.animation/transitioncollection.md)
