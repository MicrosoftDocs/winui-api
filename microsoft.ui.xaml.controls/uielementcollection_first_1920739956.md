---
-api-id: M:Microsoft.UI.Xaml.Controls.UIElementCollection.First
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterator<Windows.UI.Xaml.UIElement> First()
-->

# Microsoft.UI.Xaml.Controls.UIElementCollection.First

## -description
Returns the iterator object that can iterate over the items in the [UIElementCollection](uielementcollection.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -returns
The iterator object. The iterator's current position is at the 0-index position, or at the collection end if the collection is empty.

## -remarks
A convenient way to hold the iterator returned by First is to assign the return value to a variable that is declared with the **auto** type deduction keyword. Then use [IIterator](/uwp/api/windows.foundation.collections.iiterator`1)  API as part of a **while** loop. For example:

```cppwinrt
auto iterator1{ uieCollection.First() };
while (iterator1.HasCurrent())
{
    Windows::UI::Xaml::UIElement currentItem{ iterator1.Current() };
    // Your logic here that does something with currentItem.
    iterator1.MoveNext();
}
```

```cppcx
auto iterator1 = uieCollection->First();
while (iterator1->HasCurrent)
{
    auto currentItem = iterator1->Current;
    //your logic here that does something with currentItem
    iterator1->MoveNext();
}
```

## -examples

## -see-also
[IIterator](/uwp/api/windows.foundation.collections.iiterator`1)
