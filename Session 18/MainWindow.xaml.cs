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

namespace Session_18;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    Controller manager = new Controller();
    public MainWindow()
    {
        InitializeComponent();
        thinglist.ItemsSource = manager.Thinsg;
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
        //add
        Thing t = new Thing() {
            Name = namebox.Text,
            IsBoyOr8Ball = bor8.IsChecked.Value,
            ThingDate = datebox.SelectedDate.Value
        };
        manager.AddThing(t);
        thinglist.Items.Refresh();
    }

    private void Button_Click_1(object sender, RoutedEventArgs e) {
//delete
        Thing t = thinglist.SelectedItem as Thing;
        if (t != null) {
            manager.RemoveThing(t);
            thinglist.Items.Refresh();
        }

    }
}