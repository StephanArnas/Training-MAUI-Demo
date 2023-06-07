using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DemoLayout.Presentation.Pages;

public partial class ListViewPage : ContentPage
{
    public ObservableCollection<string> Items { get; } = new ObservableCollection<string>
        {
            "Item 1", "Item 2", "Item 3", "Item 4", "Item 5"
        };

    public ListViewPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await DisplayAlert("Item Selected", e.SelectedItem.ToString(), "OK");
        }
    }
}