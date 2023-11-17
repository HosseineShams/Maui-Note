using System.Collections.ObjectModel;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Note> Notes { get; set; }

        public MainViewModel()
        {
            Notes = new ObservableCollection<Note>();
        }

        public void AddNote(string content)
        {
            if (!string.IsNullOrWhiteSpace(content))
            {
                Notes.Add(new Note { Content = content });
            }
        }
    }
}
