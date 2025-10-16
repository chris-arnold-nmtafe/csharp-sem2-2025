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
using System.Windows.Threading;

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Verterbrate pet = new Dog();
    DispatcherTimer timer= new DispatcherTimer();
    public MainWindow()
    {
        InitializeComponent();
        timer.Interval = new TimeSpan(0, 0, 1);
        timer.Tick += updateHungry;
        timer.Start();
        typeLabel.Content = "Active Animal: " + pet;
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
        pet.Feed(foodBox.Text);
        updateHungry();
    }
    private void updateHungry(object sender=null,EventArgs e=null) {
        hungryBox.IsChecked = pet.IsHungry;
        stomach.ItemsSource = pet.Stomach;
        stomach.Items.Refresh();
    }

    private void Button_Click_1(object sender, RoutedEventArgs e) {
        pet.Stomach.Add("Lego");
        pet.Stomach.Add("Chocolate");
        pet.Stomach.Add("Cake");
        pet.Stomach.Add("Grapes");
        pet.Stomach.Add("Avocado");
    }

    private void Button_Click_2(object sender, RoutedEventArgs e) {
        pet.ThrowUpOnMumsBed();
    }
}