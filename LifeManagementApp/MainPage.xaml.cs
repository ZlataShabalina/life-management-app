namespace LifeManagementApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void WeatherClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Weather());
        }
    }

}
