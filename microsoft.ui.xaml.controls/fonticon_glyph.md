---
-api-id: P:Microsoft.UI.Xaml.Controls.FontIcon.Glyph
-api-type: winrt property
---

<!-- Property syntax
public string Glyph { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.FontIcon.Glyph

## -description
Gets or sets the character code that identifies the icon glyph.

## -xaml-syntax
```xaml
<FontIcon Glyph="characterCode"/>
```


## -xaml-values
<dl><dt>characterCode</dt><dd>characterCodeThe hexadecimal character code for the icon glyph, such as "&amp;#x00FF;".</dd>
</dl>
## -property-value
The hexadecimal character code for the icon glyph.

## -remarks

## -examples

```xaml
<FontIcon FontFamily="Segoe UI Emoji" Glyph="&#x25B6;"/>
```

```csharp
var fontIcon = new FontIcon();
fontIcon.FontFamily = new FontFamily("Segoe UI Emoji");
fontIcon.Glyph = "\x25B6";
```

```cppwinrt
using namespace winrt::Windows::UI::Xaml;
...

auto fontIcon = Controls::FontIcon{};
fontIcon.FontFamily(Media::FontFamily{ L"Segoe UI Emoji" });
fontIcon.Glyph(L"\x25B6");
```

## -see-also
