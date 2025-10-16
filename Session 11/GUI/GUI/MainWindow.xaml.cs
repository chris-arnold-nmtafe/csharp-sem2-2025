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
            Listbox_People.ItemsSource = manager.GetPeople();
        }

        private void Button_Add_Person_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            person.FirstName = Textbox_FirstName.Text;
            person.DateOfBirth = Datepicker_DateOfBirth.SelectedDate??DateTime.MinValue;
            person.LastName = Textbox_LastName.Text;
            person.Height = (int)(Combo_Height.SelectedItem??0);
            manager.Add(person);
            //Listbox_People.Items.Refresh();
            Listbox_People.ItemsSource = manager.GetPeople();
        }

        private void Button_Load_People_Click(object sender, RoutedEventArgs e)
        {
            Listbox_People.ItemsSource = manager.GetPeople();
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e) {
            string searchTerm=searchBox.Text;
            List<Person> results=manager.Search(searchTerm);
            Listbox_People.ItemsSource = results;
        }

        private void Button_Remove_Person_Click(object sender, RoutedEventArgs e) {
            Person selected = (Person)Listbox_People.SelectedItem;
            manager.Remove(selected);
            Listbox_People.ItemsSource = manager.GetPeople();
        }

        private void Button_Edit_Person_Click(object sender, RoutedEventArgs e) {
            Person selected = (Person)Listbox_People.SelectedItem;
            if (selected != null) {
                selected.FirstName = Textbox_FirstName.Text;
                selected.DateOfBirth = Datepicker_DateOfBirth.SelectedDate ?? DateTime.MinValue;
                selected.LastName = Textbox_LastName.Text;
                selected.Height = (int)(Combo_Height.SelectedItem ?? 0);
                manager.EditPerson(selected);
                Listbox_People.ItemsSource = manager.GetPeople();
            }
        }
    }
}
