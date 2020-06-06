---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationViewItem.MenuItemsSource
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.NavigationViewItem.MenuItemsSource

<!--
public object MenuItemsSource { get; set; }
-->


## -description

Gets or sets an object source used to generate the children of the NavigationViewItem.


## -property-value

The object source that holds the children of the NavigationViewItem.


## -examples
This example adds hierarchy by defining the item template to be a NavigationViewMenuItem, with its Content set to be the label of the menu item, and its MenuItemsSource property bound to the next level of the hierarchy.

```xaml
<DataTemplate x:Key="NavigationViewMenuItem" x:DataType="local:Category">
    <muxc:NavigationViewItem Content="{x:Bind Name}" MenuItemsSource="{x:Bind Children}"/>
</DataTemplate>

<muxc:NavigationView x:Name="navview" 
    MenuItemsSource="{x:Bind categories, Mode=OneWay}" 
    MenuItemTemplate="{StaticResource NavigationViewMenuItem}" 
    ItemInvoked="{x:Bind OnItemInvoked}" 
    Expanding="OnItemExpanding" 
    Collapsed="OnItemCollapsed" 
    PaneDisplayMode="Left">
    
    <StackPanel Margin="10,10,0,0">
        <TextBlock Margin="0,10,0,0" x:Name="ExpandingItemLabel" Text="Last Expanding: N/A"/>
        <TextBlock x:Name="CollapsedItemLabel" Text="Last Collapsed: N/A"/>
    </StackPanel>    
</muxc:NavigationView>
```

```csharp
public class Category
{
    public String Name { get; set; }
    public String Icon { get; set; }
    public ObservableCollection<Category> Children { get; set; }
}
    
public sealed partial class HierarchicalNavigationViewDataBinding : Page
{
    public HierarchicalNavigationViewDataBinding()
    {
        this.InitializeComponent();
    }  
    
    public ObservableCollection<Category> Categories = new ObservableCollection<Category>()
    {
        new Category(){
            Name = "Menu Item 1",
            Icon = "Icon",
            Children = new ObservableCollection<Category>() {
               new Category(){
                    Name = "Menu Item 2",
                    Icon = "Icon",
                    Children = new ObservableCollection<Category>() {
                        new Category() { 
                            Name  = "Menu Item 2", 
                            Icon = "Icon",
                            Children = new ObservableCollection<Category>() {
                                new Category() { Name  = "Menu Item 3", Icon = "Icon" },
                                new Category() { Name  = "Menu Item 4", Icon = "Icon" }
                            }
                        }
                    }
                }
            }
        },
        new Category(){
            Name = "Menu Item 5",
            Icon = "Icon",
            Children = new ObservableCollection<Category>() {
                new Category(){
                    Name = "Menu Item 6",
                    Icon = "Icon",
                    Children = new ObservableCollection<Category>() {
                        new Category() { Name  = "Menu Item 7", Icon = "Icon" },
                        new Category() { Name  = "Menu Item 8", Icon = "Icon" }
                    }
                }
            }
        },
        new Category(){ Name = "Menu Item 9", Icon = "Icon" }
    };

    private void OnItemInvoked(object sender, NavigationViewItemInvokedEventArgs e)
    {
        var clickedItem = e.InvokedItem;
        var clickedItemContainer = e.InvokedItemContainer;
    }

    private void OnItemExpanding(object sender, NavigationViewItemExpandingEventArgs e)
    {
        var nvib = e.ExpandingItemContainer;
        var name = "Last Expanding: " + nvib.Content.ToString();
        ExpandingItemLabel.Text = name;
    }

    private void OnItemCollapsed(object sender, NavigationViewItemCollapsedEventArgs e)
    {
        var nvib = e.CollapsedItemContainer;
        var name = "Last Collapsed: " + nvib.Content;
        CollapsedItemLabel.Text = name;
    }
}

public sealed class NavigationViewItemExpandingEventArgs
{
    public NavigationViewItemExpandingEventArgs() {}
    
    public object ExpandingItem { get; }
    public NavigationViewItemBase ExpandedItemContainer { get; }
    public bool IsSettingsInvoked { get; }
    public NavigationTransitionInfo RecommendedNavigationTransitionInfo { get; }
}

public sealed class NavigationViewItemCollapsedEventArgs
{
    public NavigationViewItemCollapsedEventArgs() {}
    
    public object CollapsedItem { get; }
    public NavigationViewItemBase CollapsedItemContainer { get; }
    public bool IsSettingsInvoked { get; }
    public NavigationTransitionInfo RecommendedNavigationTransitionInfo { get; }
}
```

## -xaml-syntax

```xaml
<NavigationViewItem MenuItemsSource="{x:Bind Object}" .../>
```
