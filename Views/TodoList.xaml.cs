namespace TodoList_Flowmodoro.Views;

public partial class TodoList : ContentPage
{
	public TodoList()
	{
		InitializeComponent();
	}

	private void MenuItem_OnClicked(object? sender, EventArgs e)
	{
		try
		{
			Navigation.PushAsync(new NewItem());
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
	}
}