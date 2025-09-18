using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Thursday;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
        nameLabel.Content = "Nom: ";
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
        string userText = nameBox.Text;
        nameLabel.Content = userText;
    }
    private void updateBox(object sender, RoutedPropertyChangedEventArgs<double> e) {
        Slider tinyBurger = (Slider)sender;
        //        int burgers = (int)tinyBurger.Value;
        //        string.
        nameBox.Text = tinyBurger.Value.ToString();
    }
    private void annoy(object sender, RoutedEventArgs e) {
        string additive = "";
        TextBox? theHovered = sender as TextBox;
        if (theHovered != null) {
            additive = theHovered.Text;
        }
        Slider? tinyBurger = sender as Slider;
        if (tinyBurger != null) {
            additive = tinyBurger.Value.ToString();
        }
        MessageBox.Show($"Hey! {additive}");
    }
}