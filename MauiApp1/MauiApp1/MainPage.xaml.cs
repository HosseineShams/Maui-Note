using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGoToNotePageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotePage());
        }
    }
}
