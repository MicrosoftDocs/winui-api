---
-api-id: T:Microsoft.UI.Xaml.Input.StandardUICommand
-api-type: winrt class
---

<!-- Class syntax.
public class StandardUICommand : UICommand, UICommand
-->

# Microsoft.UI.Xaml.Input.StandardUICommand

## -description

Derives from [XamlUICommand](xamluicommand.md), adding a set of standard platform commands with pre-defined properties.

## -remarks

[XamlUICommand](xamluicommand.md) implements the ICommand interface ([Windows.UI.Xaml.Input.ICommand](icommand.md) for C++ or [System.Windows.Input.ICommand](/dotnet/api/system.windows.input.icommand?view=dotnet-uwp-10.0&preserve-view=true) for C#), adding various UI properties, methods, and events.

The platform provides the following set of commands.

| Command | Icon | Keyboard shortcut | Label | Description |
| ------- | ---- | ----------------- | ----- | ----------- |
| Cut |  |  |  |  |  |
| Copy |  |  |  |  |  |
| Paste |  |  |  |  |  |
| Select All |  |  |  |  |  |
| Delete |  |  |  |  |  |
| Share |  |  |  |  |  |
| Save |  |  |  |  |  |
| Open |  |  |  |  |  |
| Close |  |  |  |  |  |
| Pause |  |  |  |  |  |
| Play |  |  |  |  |  |
| Stop |  |  |  |  |  |
| Forward |  |  |  |  |  |
| Backward |  |  |  |  |  |
| Undo |  |  |  |  |  |
| Redo |  |  |  |  |  |

## -see-also

[XamlUICommand](xamluicommand.md), [Commanding in Universal Windows Platform apps using StandardUICommand, XamlUICommand, and ICommand](/windows/apps/design/controls/commanding)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see  [Command design basics](/windows/uwp/layout/commanding-basics).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/StandardUICommand) or [**WinUI 2 Gallery**](winui2gallery:/item/StandardUICommand).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/p/winui-3-controls-gallery/9p3jfpwwdzrc) and the [**WinUI 2 Gallery**](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

