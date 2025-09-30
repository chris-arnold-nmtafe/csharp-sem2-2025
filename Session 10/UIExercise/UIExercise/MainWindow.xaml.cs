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

namespace UIExercise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataService service = new DataService();

        public MainWindow()
        {
            InitializeComponent();
//            comboEnrolment.ItemsSource = Enum.GetValues(typeof(EnrolmentStatus));
        }

        /// <summary>
        /// This is called when the get students button is pressed.
        /// TODO: Update this button to load the students from the service and update the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetStudents_Click(object sender, RoutedEventArgs e)
        {
            List<Student> students = service.GetStudents();
            listStudents.ItemsSource = students;
        }

        /// <summary>
        /// This event is triggered when the user selects a student from the list.
        /// TODO: Update the controls to show the properties of the selected student.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selected = listStudents.SelectedItem;
            Student student = (Student)selected;
            palette.Student = student;
        }

        private void buttonAddStudent_Click(object sender, RoutedEventArgs e) {
            StudentEditor editor = new StudentEditor();
            editor.StudentChanged += studentAdded;
            editor.Show();
        }

        private void studentAdded(object sender,EventArgs e) {
            StudentEditor popup = (StudentEditor)sender;
            service.AddStudent(popup.Student);
            listStudents.Items.Refresh();
        }

        private void buttonSaveStudent_Click(object sender, RoutedEventArgs e) {
            listStudents_MouseDoubleClick(sender, null);
        }

        private void listStudents_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            object selected = listStudents.SelectedItem;
            Student student = selected as Student;
            StudentEditor editor = new StudentEditor(student);
            editor.StudentChanged += studentSaved;
            editor.Show();
        }
        private void studentSaved(object sender, EventArgs e) {
            listStudents.Items.Refresh();
        }
    }
}
