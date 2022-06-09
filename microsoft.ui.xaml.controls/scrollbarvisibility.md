---
-api-id: T:Microsoft.UI.Xaml.Controls.ScrollBarVisibility
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.ScrollBarVisibility : int
-->

# ScrollBarVisibility

## -description
Defines constants that specify the visibility of a scrollbar within a [ScrollViewer](scrollviewer.md) control.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field Disabled:0
A [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md) does not appear even when the viewport cannot display all of the content. Scrolling is disabled.

The dimension of the content is set to the corresponding dimension of the [ScrollViewer](scrollviewer.md) parent. For a horizontal [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md), the width of the content is set to the [ViewportWidth](scrollviewer_viewportwidth.md) of the [ScrollViewer](scrollviewer.md). For a vertical [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md), the height of the content is set to the [ViewportHeight](scrollviewer_viewportheight.md) of the [ScrollViewer](scrollviewer.md).

### -field Auto:1
A [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md) appears only when the viewport cannot display all of the content.

The dimension of the content is set to the corresponding dimension of the [ScrollViewer](scrollviewer.md) parent. For a horizontal [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md), the width of the content is set to the [ViewportWidth](scrollviewer_viewportwidth.md) of the [ScrollViewer](scrollviewer.md). For a vertical [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md), the height of the content is set to the [ViewportHeight](scrollviewer_viewportheight.md) of the [ScrollViewer](scrollviewer.md).

### -field Hidden:2
A [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md) does not appear even when the viewport cannot display all of the content. Scrolling is still enabled, and can occur through touch, keyboard, or mouse wheel interaction.

The dimension of the content is not affected by the dimension of the [ScrollViewer](scrollviewer.md).

### -field Visible:3
A [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md) always appears.

The dimension of the content is set to the corresponding dimension of the [ScrollViewer](scrollviewer.md) parent. For a horizontal [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md), the width of the content is set to the [ViewportWidth](scrollviewer_viewportwidth.md) of the [ScrollViewer](scrollviewer.md). For a vertical [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md), the height of the content is set to the [ViewportHeight](scrollviewer_viewportheight.md) of the [ScrollViewer](scrollviewer.md).


## -remarks

## -examples
The following example shows how to use the ScrollBarVisibility enumeration members to set the [HorizontalScrollBarVisibility](scrollviewer_horizontalscrollbarvisibility.md) property of a [ScrollViewer](scrollviewer.md) control.



[!code-xaml[1](../microsoft.ui.xaml.data/code/System.Windows.Controls.ScrollBarVisibilityEx/csharp/Page.xaml#Snippet1)]

## -see-also
