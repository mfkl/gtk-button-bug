using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GTK_Button_bug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void nextButton_Clicked(object sender, EventArgs e)
        {
            throw new Exception("fire");
        }
    }
}
