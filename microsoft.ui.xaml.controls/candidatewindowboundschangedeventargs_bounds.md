---
-api-id: P:Microsoft.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs.Bounds
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Rect Bounds { get; }
-->

# Microsoft.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs.Bounds

## -description
Gets the [Rect](/uwp/api/windows.foundation.rect) that defines the size and location of the Input Method Editor (IME) window, in the coordinate space of the text edit control.

## -property-value
The [Rect](/uwp/api/windows.foundation.rect) that defines the size and location of the Input Method Editor (IME) window

## -remarks
This property gets a [Rect](/uwp/api/windows.foundation.rect) that defines the size and location of the Input Method Editor (IME), in the coordinate space of the text control (upper left hand corner). This is (0,0,0,0) if there is no window, or if the Input Method Editor (IME) is aligned to the Soft Input Panel (SIP).

## -examples

## -see-also
[TextBox.CandidateWindowBoundsChanged](textbox_candidatewindowboundschanged.md), [RichEditBox.CandidateWindowBoundsChanged](richeditbox_candidatewindowboundschanged.md)
