using System.ComponentModel;

namespace MauiAndroidScrollViewBug
{
    public partial class MainPage : ContentPage
    {

        private readonly MainPageViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainPageViewModel();
            BindingContext = viewModel;
        }

        private void ListView_Scrolled(object sender, ScrolledEventArgs e)
        {
            viewModel.ScrollY = e.ScrollY;
            viewModel.NotifyPropertyChanged(nameof(viewModel.ScrollY));
        }
    }

}
