
using MixCloud_App.ViewModels;

namespace MixCloud_App;

public partial class MainPage : ContentPage
{

	MainViewModel viewModel = new MainViewModel();

	public MainPage()
	{
		InitializeComponent();
	}

	private async void ButtonClicked(object sender, EventArgs e)
	{
		try
		{
			var query = searchEntry.Text;
			var type = searchTypePicker.SelectedItem.ToString() ?? "cloudcast";
			await viewModel.SearchMixCloudAsync(query, type);
			BindingContext = viewModel;
		}
		catch (Exception ex)
		{
			await DisplayAlert("Error", ex.Message, "OK");
		}
	}

	public async void GoToMixCloudButtonClicked(object sender, EventArgs e)
	{
		var url = ((Button)sender).CommandParameter.ToString();
		if (url != null)
			await Launcher.OpenAsync(url);
	}
}

