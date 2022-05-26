---
-api-id: T:Microsoft.UI.Input.InputDesktopResourceCursor
-api-type: winrt class
---

# Microsoft.UI.Input.InputDesktopResourceCursor

<!--
public sealed class InputDesktopResourceCursor : Microsoft.UI.Input.InputCursor
-->

## -description

Represents a visual pointer object that uses an application resource instead of a predefined system cursor.

## -remarks

Derived from [InputCursor](inputcursor.md).

Uses a resource ID. If you need to use a string resource name instead, see <xref:Microsoft.UI.Input.InputDesktopNamedResourceCursor> (Visual Studio assigns a unique integer ID to new resources).

You can add a _.res_ resource file that contains a custom cursor to your project and include it in your assembly with the [/win32res](/dotnet/articles/csharp/language-reference/compiler-options/win32res-compiler-option) compiler option. The **Id** is the [Cursor Resource ID](/windows/desktop/menurc/cursor-resource) specified in the _.res_ file.

## -see-also

[InputSystemCursorShape](inputsystemcursorshape.md), [InputSystemCursor](inputsystemcursor.md)

## -examples
