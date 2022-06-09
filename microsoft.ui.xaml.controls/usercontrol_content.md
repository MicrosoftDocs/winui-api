---
-api-id: P:Microsoft.UI.Xaml.Controls.UserControl.Content
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.UIElement Content { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.UserControl.Content

## -description
Gets or sets the content that is contained within a user control.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<UserControl ...>
  singleContentElement
</UserControl>
-or-
<UserControl .../>
```


## -xaml-values
<dl><dt>singleContentElement</dt><dd>singleContentElementExactly one object element for a class that derives from UIElement. This is almost always an object that can take child elements (such as a Panel) so that multiple elements can be added to content. XAML processing of a UserControl has a special behavior that sets this content to the otherwise protected Content property.</dd>
</dl>
## -property-value
The content of the user control.

## -remarks

## -examples

## -see-also
