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
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Interaction logic for JobEditor.xaml
    /// </summary>
    public partial class JobEditor : Window
    {
        public Job JobToEdit { get; set; }

        public event EventHandler ItsOK;
        public JobEditor(Job job)
        {
            JobToEdit = job;
            InitializeComponent();
            titleBox.Text=JobToEdit.Title;
            dateBox.SelectedDate = JobToEdit.Date;
            completeBox.IsChecked = JobToEdit.Completed;
            costBox.Text=JobToEdit.Cost.ToString();
            assigneeBox.Text = JobToEdit.AssignedContractor?.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            JobToEdit.Title = titleBox.Text;
            JobToEdit.Date = (DateTime)dateBox.SelectedDate;
            JobToEdit.Completed = (bool)completeBox.IsChecked;
            float cost;
            if (float.TryParse(costBox.Text,out cost)) {
                JobToEdit.Cost = cost;
            }
            if (ItsOK!=null) {
                ItsOK(this,new EventArgs());
            }
            Close();
        }

        private void costBox_TextChanged(object sender, TextChangedEventArgs e) {
        }

        private void assigneeBox_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            TextBox textBox = sender as TextBox;
            if (textBox != null) {
                string input = textBox.Text+e.Text;
                if (!float.TryParse(input,out _)) {
                    e.Handled = true;
                }
            }
        }
    }
}
