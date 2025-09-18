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

namespace WpfApp1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        List<Person> people = new List<Person>();

        public MainWindow() {
            InitializeComponent();
            nameList.ItemsSource = people;
        }
        private void createPerson(object sender, RoutedEventArgs e) {
            Person person = new Person();
            person.GivenName = givenName.Text;
            person.FamilyName = familyName.Text;
            people.Add(person);
            nameList.Items.Refresh();
        }

    }
}