namespace SPEISEKARTEUPDATE;

public partial class Page2 : ContentPage 
{
    public Page2()
    {
        InitializeComponent();
    }
    async void navigateTo(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page3());
    }

}
