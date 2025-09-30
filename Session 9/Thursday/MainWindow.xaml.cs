using System.Text;
using Friday;
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
        List<SurveyItem> surveys = new List<SurveyItem>();
        for (int i=0;i<10;++i) {
            surveys.Add(new SurveyItem());
        }
        exGrid.ItemsSource = surveys;

        //int maxlen = ints.Max(x => x.Length);
    }
    private void ListPrinting() {
        List<int> someNumbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
        List<string> someOtherThings = new List<string>() { "one", "two", "three" };
        DoAThing(someNumbers);
        DoAThing(someOtherThings);
        System.Collections.ArrayList oldList= new System.Collections.ArrayList();
        oldList.Add("one");
        oldList.Add(1);
        oldList.Add(1.283);
        DoAThing(oldList);
    }
    private void DoAThing(System.Collections.IList things) {
        string message = "";
        foreach (object thing in things) {
            message += $"{thing}, ";
        }
        MessageBox.Show(message);
    }
    private void updateBox(object sender, RoutedPropertyChangedEventArgs<double> e) {
        Slider tinyBurger = (Slider)sender;
        //        int burgers = (int)tinyBurger.Value;
        //        string.
        nameBox.Text = tinyBurger.Value.ToString();
    }
    private void annoy(object sender, RoutedEventArgs e) {
        return;
        string additive = "";
        int burgers = 1;
        TextBox? theHovered = sender as TextBox;
        if (theHovered != null) {
            additive = theHovered.Text;
        }
        Slider? tinyBurger = sender as Slider;
        if (tinyBurger != null) {
            burgers = (int)tinyBurger.Value;
            additive = tinyBurger.Value.ToString();
        }
        if (burgers>=0) {
            additive = "🍔".Repeat(burgers);
        }
        MessageBox.Show($"Hey! {additive}");
//        doubleBurger.ShowUsYourBurgers();
    }
}