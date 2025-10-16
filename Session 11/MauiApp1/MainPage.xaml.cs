namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        PersonManager manager = new PersonManager();

        public MainPage()
        {
            InitializeComponent();
            personList.ItemsSource = manager.GetPeople();
        }

        private void OnAddPoisonClicked(object sender, EventArgs e)
        {
            Person person = new Person();
            person.FirstName = firstName_box.Text;
            person.DateOfBirth = dob_picker.DateSelected;
            person.LastName = lastName_box.Text;
            person.Height = height_picker.SelectedItem;
            manager.Add(person);
            personList.Items.Refresh();
        }
    }

}
