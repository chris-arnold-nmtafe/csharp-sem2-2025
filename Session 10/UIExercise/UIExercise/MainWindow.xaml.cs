using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

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
            comboEnrolment.ItemsSource = Enum.GetValues(typeof(EnrolmentStatus));
        }

        /// <summary>
        /// This is called when the get students button is pressed.
        /// TODO: Update this button to load the students from the service and update the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetStudents_Click(object sender, RoutedEventArgs e)
        {
            listStudents.ItemsSource = service.GetStudents();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">The UI control that triggers the change</param>
        /// <param name="e"></param>
        private void listStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selected = (Student)listStudents.SelectedItem;
            textBoxFirstName.Text = selected.FirstName;
            textBoxLastName.Text = selected.LastName;
            comboEnrolment.SelectedValue = selected.Enrolment;
        }

        /// <summary>
        /// This event triggers when the combo box selection is changed.
        /// TODO: It should update the selected students enrolment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboEnrolment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selected = (Student)listStudents.SelectedItem;
            if (selected != null) {
                selected.Enrolment = (EnrolmentStatus)comboEnrolment.SelectedValue;
            }
            listStudents.Items.Refresh();
        }

        private void editStudent_Click(object sender, RoutedEventArgs e) {
            Student selected = (Student)listStudents.SelectedItem;
            if (selected != null) {
                selected.FirstName = textBoxFirstName.Text;
                selected.LastName = textBoxLastName.Text;
                selected.Enrolment = (EnrolmentStatus)comboEnrolment.SelectedValue;
            }
            listStudents.Items.Refresh();
        }

        private void addStudent_Click(object sender, RoutedEventArgs e) {
            Student newStudent = new Student() {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Enrolment = (EnrolmentStatus)comboEnrolment.SelectedValue
            };
            service.AddStudent(newStudent);
            listStudents.Items.Refresh();
        }
    }
}
