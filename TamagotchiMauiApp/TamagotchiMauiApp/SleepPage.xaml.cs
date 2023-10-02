namespace TamagotchiMauiApp;

public partial class SleepPage : ContentPage
{
	public SleepPage()
	{
		InitializeComponent();
		BindingContext = this;
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        var dataStore = DependencyService.Get<IDataStore<Creature>>();
        Creature myCreaturePet = await dataStore.ReadItem();

        float decreaseAmount = myCreaturePet.Tired * 0.1f;
        myCreaturePet.Tired -= decreaseAmount;

        await dataStore.UpdateItem(myCreaturePet);
    }
}