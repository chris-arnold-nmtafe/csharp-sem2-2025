using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Images
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ImageService Service = new ImageService();

        public MainWindow()
        {
            InitializeComponent();
            //Load the files into the combo box.
            ComboImages.ItemsSource = Service.GetFiles();
        }

        private void ButtonShowImage_Click(object sender, RoutedEventArgs e)
        {
            string name = ComboImages.SelectedItem.ToString();
            imageView.Source = new BitmapImage(new Uri(Service.GetFullString(name)));

            //Basic assignment directly
            //imageView.Source = new BitmapImage(new Uri("./Images/jag1.jpg", UriKind.Relative));
        }
    }
}
