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
using Microsoft.Win32;

namespace Session_19;

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
        OpenFolderDialog folDiaglogue = new OpenFolderDialog();
        bool? allIsOk = folDiaglogue.ShowDialog();
        string shozenPath = null;
        if (allIsOk == true) {
            shozenPath = folDiaglogue.FolderName;
            MessageBox.Show(shozenPath);
        }

        OpenFileDialog ofd = new OpenFileDialog();
        bool? result = ofd.ShowDialog();
        if (result == true) {
            pathBox.Text = ofd.FileName;
        }
    }

    private void Button_Click_1(object sender, RoutedEventArgs e) {
        MessageBox.Show(pathBox.Text);
    }
}