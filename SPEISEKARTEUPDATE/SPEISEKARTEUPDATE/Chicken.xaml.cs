namespace SPEISEKARTEUPDATE;

public partial class Chicken : ContentPage
{
    int count = 0;
    int zähl = 0;
    int dawg = 0;
    public Chicken()
	{
		InitializeComponent();
	}
    async void navigateTo(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page3());
    }

    private void CLS(object sender, EventArgs e)
    {
        zähl++;

        if (zähl == 1)
            Zähler.Text = $"{zähl}";
        else
            Zähler.Text = $"{zähl} ";

        SemanticScreenReader.Announce(Zähler.Text);
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"{count}";
        else
            CounterBtn.Text = $"{count} ";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
    private void ASS(object sender, EventArgs e)
    {
        dawg++;

        if (dawg == 1)
            Dawger.Text = $"{dawg}";
        else
            Dawger.Text = $"{dawg} ";

        SemanticScreenReader.Announce(Dawger.Text);
    }



}