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

namespace Project;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
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
}