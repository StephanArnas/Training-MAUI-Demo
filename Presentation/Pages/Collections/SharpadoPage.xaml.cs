using Sharpnado.TaskLoaderView;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DemoLayout.Presentation.Pages;

public partial class SharpadoPage : ContentPage
{
    public ObservableCollection<string> Items { get; } = new ObservableCollection<string>
        {
            "Item 1", "Item 2", "Item 3", "Item 4", "Item 5"
        };

    public ICommand ItemTapped => new TaskLoaderCommand<string>(OnItemSelected);


    public SharpadoPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    public async Task OnItemSelected(string item)
    {
        if (item != null)
        {
            await DisplayAlert("Item Selected", item, "OK");
        }
    }
}