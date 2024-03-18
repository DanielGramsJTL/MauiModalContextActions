using System.Collections.ObjectModel;

namespace MauiApp2
{
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
            this.listView.ItemsSource = this.Objects;
        }

        public object[] Objects { get; set; } = {"1", "2", "3"};


        private void MenuItem_OnClicked(object? sender, EventArgs e)
        {
            Console.WriteLine("jo");
        }

        private async void Button_OnClicked(object? sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }

}
