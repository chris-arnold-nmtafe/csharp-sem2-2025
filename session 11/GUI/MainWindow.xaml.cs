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

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonManager manager = new PersonManager(20);

        public MainWindow()
        {
            InitializeComponent();
            for (int i = 150; i <= 210; i++)
            {
                Combo_Height.Items.Add(i);
            }

        }

        private void Button_Add_Person_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person() {
                FirstName = Textbox_FirstName.Text,
                LastName = Textbox_LastName.Text,
                DateOfBirth = Datepicker_DateOfBirth.SelectedDate ?? DateTime.MinValue,
                Height = (int)(Combo_Height.SelectedItem ?? 0)
            };
            manager.Add(person);
            //            Listbox_People.Items.Refresh();
            Listbox_People.ItemsSource = manager.GetPeople();
        }

        private void Button_Load_People_Click(object sender, RoutedEventArgs e)
        {
            Listbox_People.ItemsSource = manager.GetPeople();
        }

        private void People_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Person selected = (Person)Listbox_People.SelectedItem;
            if (selected != null) {
                Textbox_FirstName.Text = selected.FirstName;
                Textbox_LastName.Text = selected.LastName;
                Datepicker_DateOfBirth.SelectedDate = selected.DateOfBirth;
                Combo_Height.SelectedValue = (int)selected.Height;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Listbox_People.ItemsSource = manager.Search(new DateTime(1900,1,1), new DateTime(1950,1,1));
        }
    }
}
