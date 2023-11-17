using Microsoft.Maui.Controls;
using MauiApp1.ViewModels;

namespace MauiApp1
{
    public partial class NotePage : ContentPage
    {
        MainViewModel viewModel;

        public NotePage()
        {
            InitializeComponent();

            viewModel = new MainViewModel();
            BindingContext = viewModel;
        }

        private void OnAddNoteClicked(object sender, EventArgs e)
        {
            viewModel.AddNote(noteEntry.Text);
            noteEntry.Text = string.Empty;
        }

    }
}
