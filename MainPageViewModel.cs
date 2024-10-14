using System.ComponentModel;
using System.Windows.Input;

namespace MauiAndroidListViewBug
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public MainPageViewModel()
        {
            Items = Enumerable.Range(0, 1000).Select(i => i.ToString()).ToList();
            NotifyPropertyChanged(nameof(Items));
        }

        public List<string> Items { get; set; }

        public double ScrollY { get; set; }

        public ICommand Command
        {
            get => new Command(() =>
            {
                Items = Items.Take(100).ToList();
                NotifyPropertyChanged(nameof(Items));
            });
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
