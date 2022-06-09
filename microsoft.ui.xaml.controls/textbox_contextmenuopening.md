---
-api-id: E:Microsoft.UI.Xaml.Controls.TextBox.ContextMenuOpening
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Controls.ContextMenuOpeningEventHandler ContextMenuOpening
-->

# Microsoft.UI.Xaml.Controls.TextBox.ContextMenuOpening

## -description

Occurs when the system processes an interaction that displays a context menu.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<TextBox ContextMenuOpening="eventhandler" />
```

## -remarks

To override or add commands to the context menu, you can handle the ContextMenuOpening event and replace the default menu with a custom menu. For more info, see [Guidelines for context menus](/windows/apps/design/controls/menus).

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Text box](/windows/apps/design/controls/text-box).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/TextBox) or [**WinUI 2 Gallery**](winui2gallery:/item/TextBox).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

## -see-also

[ContextMenuOpeningEventHandler](contextmenuopeningeventhandler.md), [Guidelines for context menus](/windows/apps/design/controls/index), [ContextMenu sample](https://github.com/microsoft/Windows-universal-samples/tree/master/archived/ContextMenu)
