---
-api-id: M:Microsoft.UI.Xaml.Controls.UIElementCollection.InsertAt(System.UInt32,Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public void InsertAt(System.UInt32 index, Windows.UI.Xaml.UIElement value)
-->

# Microsoft.UI.Xaml.Controls.UIElementCollection.InsertAt

## -description
Inserts the specified item at the specified index.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param index
The index at which to set the value.

### -param value
The value to set.

## -remarks
InsertAt expands the collection and moves all subsequent index items by one. In contrast, [SetAt](uielementcollection_setat_920078542.md) replaces the item at the index, and the collection count remains the same.

If you are programming using C# or Microsoft Visual Basic, see [Insert](/uwp/api/windows.ui.xaml.controls.uielementcollection.insert).

## -examples

## -see-also
