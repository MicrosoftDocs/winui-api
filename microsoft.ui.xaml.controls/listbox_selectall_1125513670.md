---
-api-id: M:Microsoft.UI.Xaml.Controls.ListBox.SelectAll
-api-type: winrt method
---

<!-- Method syntax
public void SelectAll()
-->

# Microsoft.UI.Xaml.Controls.ListBox.SelectAll

## -description
Selects all the items in the [ListBox](listbox.md) control.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
> [!WARNING]
> The SelectAll method should only be called when the [SelectionMode](listbox_selectionmode.md) property is set to [Multiple](selectionmode.md) or [Extended](selectionmode.md). If SelectAll is called when the [SelectionMode](listbox_selectionmode.md) is **Single**, an exception is thrown.

## -examples
```csharp
if (listBox.SelectionMode != SelectionMode.Single)
{
    listBox.SelectAll();
}
```

```cppwinrt
if (listBox().SelectionMode() != Windows::UI::Xaml::Controls::SelectionMode::Single)
{
    listBox().SelectAll();
}
```

```cppcx
if (listBox->SelectionMode != SelectionMode::Single)
{
    listBox->SelectAll();
}
```

```vbnet
If listBox.SelectionMode <> SelectionMode.Single Then
    listBox.SelectAll()
End If
```



## -see-also
