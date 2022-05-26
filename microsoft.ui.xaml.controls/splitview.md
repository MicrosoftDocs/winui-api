---
-api-id: T:Microsoft.UI.Xaml.Controls.SplitView
-api-type: winrt class
---

<!-- Class syntax.
public class SplitView : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.ISplitView, Windows.UI.Xaml.Controls.ISplitView2
-->

# Microsoft.UI.Xaml.Controls.SplitView

## -description

Represents a container with two views; one view for the main content and another view that is typically used for navigation commands.

## -xaml-syntax

```xaml
<SplitView>
  <SplitView.Content>
    singleObject
  </SplitView.Content>
  <SplitView.Pane>
    singleObject
  </SplitView.Pane>
</SplitView>

```

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Split view](/windows/apps/design/controls/split-view).

The SplitView control presents two areas of content: a [Pane](splitview_pane.md) and the main [Content](splitview_content.md). You typically use a SplitView to create a top-level navigation experience that adapts to different screen widths following the [nav pane pattern](/windows/uwp/controls-and-patterns/nav-pane) or the [master/details pattern](/windows/apps/design/controls/master-details), but it's not strictly limited to use for navigation.

The XAML for this SplitView is shown in the Examples section.

<img alt="Split view control" src="images/controls/SplitViewBasic.png" />

The [Content](splitview_content.md) area is always present and can contain a single child element, which is typically a [Panel](panel.md) derived container that contains additional child elements. Although the [Content](splitview_content.md) is always present, it can be completely covered by the [Pane](splitview_pane.md).

There are several properties you can set to control the appearance and behavior of the [Pane](splitview_pane.md). Set the [IsPaneOpen](splitview_ispaneopen.md) property to open or close the [Pane](splitview_pane.md). The SplitView does not include a built-in affordance for users to toggle the state of the [Pane](splitview_pane.md), like a menu (or "hamburger") button. You must provide this affordance and the code to toggle the [IsPaneOpen](splitview_ispaneopen.md) property.

To specify the length of the open pane, set the [OpenPaneLength](splitview_openpanelength.md) property. You can set the [PanePlacement](splitview_paneplacement.md) property to have the [Pane](splitview_pane.md) appear on either the left or right side of the [Content](splitview_content.md).

Although the appearance of the control is largely based on the elements assigned to the [Pane](splitview_pane.md) and [Content](splitview_content.md), you can change the default background color of the [Pane](splitview_pane.md) by setting the [PaneBackground](splitview_panebackground.md).

Set the [DisplayMode](splitview_displaymode.md) property to configure the interaction of the [Pane](splitview_pane.md) with the [Content](splitview_content.md). By default, the [Pane](splitview_pane.md) overlays the [Content](splitview_content.md) and disappears completely when closed. You can use one of the "inline" modes to show the [Pane](splitview_pane.md) side-by-side with the [Content](splitview_content.md). You can use the "compact" modes to make a narrow section of the [Pane](splitview_pane.md) remain visible even when the [Pane](splitview_pane.md) is closed. See the [SplitViewDisplayMode](splitviewdisplaymode.md) enumeration for more info about the supported modes.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Split view](/windows/apps/design/controls/split-view).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/SplitView) or [**WinUI 2 Gallery**](winui2gallery:/item/SplitView).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


Here's a SplitView control with an open [Pane](splitview_pane.md) appearing inline next to the [Content](splitview_content.md).

```xaml
<SplitView IsPaneOpen="True"
           DisplayMode="Inline"
           OpenPaneLength="296">
    <SplitView.Pane>
        <TextBlock Text="Pane"
                   FontSize="24"
                   VerticalAlignment="Center"
                   HorizontalAlignment="Center"/>
    </SplitView.Pane>

    <Grid>
        <TextBlock Text="Content"
                   FontSize="24"
                   VerticalAlignment="Center"
                   HorizontalAlignment="Center"/>
    </Grid>
</SplitView>
```

## -see-also

[Split view control overview](/windows/apps/design/controls/split-view)
