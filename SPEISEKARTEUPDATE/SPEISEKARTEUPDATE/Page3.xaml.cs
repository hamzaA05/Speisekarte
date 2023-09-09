namespace SPEISEKARTEUPDATE;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}
    async void navigateTo(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Ende());
    }
    async void BurgerTime(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Burgers());
    }
    async void HotDawg(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HotDog());
    }
    async void Grill(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Grill());
    }
    async void ChickenLegBis(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Chicken());
    }

}