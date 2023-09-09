namespace SPEISEKARTEUPDATE;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}


	async void navigateTo(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Page2());
	}
}

