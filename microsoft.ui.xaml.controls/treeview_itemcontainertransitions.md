---
-api-id: P:Microsoft.UI.Xaml.Controls.TreeView.ItemContainerTransitions
-api-type: winrt property
---
<!-- Property syntax.
public TransitionCollection ItemContainerTransitions { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TreeView.ItemContainerTransitions



## -description

Gets or sets the collection of [Transition](/uwp/api/windows.ui.xaml.media.animation.transition) style elements that apply to the item containers of a TreeView.



**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

The collection of [Transition](/uwp/api/windows.ui.xaml.media.animation.transition) style elements that apply to the item containers of an [ItemsControl](/uwp/api/windows.ui.xaml.controls.itemscontrol).



## -remarks



## -see-also



## -examples



## -xaml-syntax

```xaml
<TreeView>
  <TreeView.ItemContainerTransitions>
    <TransitionCollection>
      oneOrMoreTransitions
    </TransitionCollection>
  </TreeView.ItemContainerTransitions>
</TreeView>
```



## -xaml-values

<dl><dt>oneOrMoreTransitions</dt><dd>oneOrMoreTransitionsOne or more object elements instantiating types that are derived from the Transition base type. Typically there is only one of each type of transition included in the collection.</dd>
</dl>



