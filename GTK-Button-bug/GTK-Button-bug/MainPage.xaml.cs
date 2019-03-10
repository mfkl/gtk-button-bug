using System;
using Xamarin.Forms;

namespace GTK_Button_bug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var button = new Button() { Text = "next", HorizontalOptions = LayoutOptions.Center };
            button.Clicked += Button_Clicked;
            mainLayout.Children.Add(button);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            throw new Exception("fire");
        }
    }
}