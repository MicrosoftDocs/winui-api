---
-api-id: M:Microsoft.UI.Xaml.Controls.ListViewBase.CompleteViewChange
-api-type: winrt method
---

<!-- Method syntax
public void CompleteViewChange()
-->

# Microsoft.UI.Xaml.Controls.ListViewBase.CompleteViewChange

## -description
Changes related aspects of presentation when the overall view for a [SemanticZoom](isemanticzoominformation.md) changes.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
Controls derived from [ListViewBase](listviewbase.md) typically have an associated [ScrollViewer](scrollviewer.md) as part of their template. The [ListViewBase](listviewbase.md) implementation of [CompleteViewChange](isemanticzoominformation_completeviewchange_1917507883.md) perpetuates [ScrollBarVisibility](scrollbarvisibility.md) for any scroll bars across the views when the views change.

## -examples

## -see-also
[ISemanticZoomInformation](isemanticzoominformation.md), [IsActiveView](listviewbase_isactiveview.md), [IsZoomedInView](listviewbase_iszoomedinview.md), [SemanticZoomOwner](listviewbase_semanticzoomowner.md), [CompleteViewChangeFrom](listviewbase_completeviewchangefrom_996733196.md), [CompleteViewChangeTo](listviewbase_completeviewchangeto_400609881.md), [InitializeViewChange](listviewbase_initializeviewchange_1165335344.md), [MakeVisible](listviewbase_makevisible_497090924.md), [StartViewChangeFrom](listviewbase_startviewchangefrom_1194830824.md), [StartViewChangeTo](listviewbase_startviewchangeto_1278247285.md)
