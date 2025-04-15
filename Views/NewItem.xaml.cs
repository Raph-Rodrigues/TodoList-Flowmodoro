using TodoList_Flowmodoro.Models;

namespace TodoList_Flowmodoro.Views;

public partial class NewItem : ContentPage
{
	public NewItem()
	{
		InitializeComponent();
	}

	private async void MenuItem_OnClicked(object? sender, EventArgs e)
	{
		try
		{
			TodoItem tdList = new()
			{
				Description = txt_description.Text
			};

			await App.DB.Insert(tdList);
			await DisplayAlert("Sucesso!", "Registro inserido", "OK");
		}
		catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "Ok");
		}
	}
}