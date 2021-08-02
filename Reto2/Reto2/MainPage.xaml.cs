using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Reto2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ClickOnButton(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.Background = Brush.Blue;
        }
    }
}
