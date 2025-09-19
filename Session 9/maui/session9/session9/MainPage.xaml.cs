using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace session9
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void textEntered(object sender, EventArgs e)
        {
            //This is invoked when you finish typing into the "sampleInput" text box.
            //The MAUI label is slightly different from the WPF one. Its text property
            //is .Text rather than .Content. More consistent than WPF!
            nameLabel.Text = sampleInput.Text;
        }

        void tinyBurger_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //This is invoked when the slider moves
            //The slider is raising the event, so it's the "sender"
            Slider slider = (Slider)sender;
            int burgerCount = (int)slider.Value;
            burgerText.Text = "🍔".Repeat(burgerCount);
        }
    }
}

