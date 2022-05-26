---
-api-id: T:Microsoft.UI.Xaml.Input.XamlUICommand
-api-type: winrt class
---

<!-- Class syntax.
public class XamlUICommand : DependencyObject, DependencyObject, ICommand
-->

# Microsoft.UI.Xaml.Input.XamlUICommand

## -description

Provides a base class for defining the command behavior of an interactive UI element that performs an action when invoked (such as sending an email, deleting an item, or submitting a form).

## -remarks

Implements the ICommand interface ([Windows.UI.Xaml.Input.ICommand](icommand.md) for C++ or [System.Windows.Input.ICommand](/dotnet/api/system.windows.input.icommand?view=dotnet-uwp-10.0&preserve-view=true) for C#), adding various UI properties, methods, and events.

### XamlUICommand derived classes

XamlUICommand is the parent class for [StandardUICommand](standarduicommand.md), which exposes a set of standard platform commands with pre-defined properties.

For a basic commanding example see the [Button](../microsoft.ui.xaml.controls/button.md) control, which is designed to make something happen when a user clicks it.

There are two ways to process a Button command (controls with a Command property support similar functionality):

- Handle the Click event
- Bind the Command property to an ICommand implementation that describes the command logic

XamlUICommand lets you specify UI through the control binding, such as an icon, label, description, and keyboard shortcuts (both an access key and a keyboard accelerator), without setting the individual properties.

## -see-also

[StandardUICommand](standarduicommand.md), [Commanding in Universal Windows Platform apps using StandardUICommand, XamlUICommand, and ICommand](/windows/apps/design/controls/commanding)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see  [Command design basics](/windows/uwp/layout/commanding-basics).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/StandardUICommand) or [**WinUI 2 Gallery**](winui2gallery:/item/StandardUICommand).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

