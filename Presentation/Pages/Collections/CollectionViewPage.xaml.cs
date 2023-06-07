using System.Collections.ObjectModel;

namespace DemoLayout.Presentation.Pages;

public partial class CollectionViewPage : ContentPage
{
    public ObservableCollection<string> Items { get; } = new ObservableCollection<string>
    {
        "Item 1", "Item 2", "Item 3", "Item 4", "Item 5"
    };

    public CollectionViewPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
        {
            await DisplayAlert("Item Selected", e.CurrentSelection[0].ToString(), "OK");
        }
    }
}