using System.ComponentModel.DataAnnotations;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    List<Job> jobs= new List<Job>() { new Job("Do Things",100),new Job("Do MOAR things",101),new Job("Write Codez",5)};
    List<string> jobHeadings = new List<string>() { "hERE'S some text (which corresponds to 'Do Things'", "which is very very descriptive of MOAR things", "of each job. which is writeing the codez" };
    public MainWindow()
    {
        InitializeComponent();
        jobBox.ItemsSource = jobHeadings;
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
        Job job = new Job(null,0);
        JobEditor editor = new JobEditor(job);
        editor.ShowDialog();
        jobList.ItemsSource = new Job[] { job };
    }
    private void Button2_Click(object sender, RoutedEventArgs e) {
        Job job = new Job("Do Things", 5);
        job.AssignedContractor = new Contractor();
        JobEditor editor = new JobEditor(job);
        editor.Show();
    }

    private void selectedJob(object sender, SelectionChangedEventArgs e) {
        //Job selectedJob=jobBox.SelectedItem as Job;
        Job selectedJob = jobs[jobBox.SelectedIndex];
        if (selectedJob != null) {
            infoLabel.Content = selectedJob.ToString();
            jobBox.Tag = selectedJob;
        }
    }

    //poopre-condition: a numeric value has been types into numberBox
    //pre-condition: the user has typed something into numberBox
    private void Button_Click_1(object sender, RoutedEventArgs e) {
        string text = numberBox.Text;
        int number = 0;
        try {
            number = int.Parse(text);
        } catch (FormatException ve) {
            MessageBox.Show(ve.Message);
        }
        MessageBox.Show(number.ToString());
    }
}