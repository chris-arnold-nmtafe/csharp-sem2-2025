using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Friday {
    public static class Utils {
        public static string Repeat(this string text, int count) {
            string result = "";
            for (int i = 0; i < count; i++) {
                result += text;
            }
            return result;
        }
        public static void ShowUsYourBurgers(this Slider slider) {
            MessageBox.Show("Hej! " + "🍔".Repeat((int)slider.Value));
        }
    }
}
