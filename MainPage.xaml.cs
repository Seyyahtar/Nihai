namespace Nihai
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCaseCardTapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CasePage));
        }
    }
}
