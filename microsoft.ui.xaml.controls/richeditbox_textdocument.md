---
-api-id: P:Microsoft.UI.Xaml.Controls.RichEditBox.TextDocument
-api-type: winrt property
---

<!-- Property syntax.
public RichEditTextDocument TextDocument { get; }
-->

# Microsoft.UI.Xaml.Controls.RichEditBox.TextDocument

## -description

Gets an object that enables access to the text object model for the text contained in a [RichEditBox](richeditbox.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

An object that enables access to the text object model.

## -remarks

The TextDocument property is equivalent to the [Document](richeditbox_document.md) property except for the type. The Document property is of type [ITextDocument](/windows.ui.text/itextdocument.md), and can be type cast to RichEditTextDocument. The TextDocument property, on the other hand, is already typed as RichEditTextDocument, so no type cast is necessary.


## -see-also

## -examples

