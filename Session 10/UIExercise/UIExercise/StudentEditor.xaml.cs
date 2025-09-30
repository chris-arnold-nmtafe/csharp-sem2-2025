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

namespace UIExercise
{
    /// <summary>
    /// Interaction logic for StudentEditor.xaml
    /// </summary>
    public partial class StudentEditor : Window
    {
        internal Student Student { get; set; }

        public event EventHandler StudentChanged;

        public StudentEditor(Student toEdit=null)
        {
            InitializeComponent();
            if (toEdit != null) {
                palette.Student = toEdit;
            }
            Student = palette.Student;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            palette.UpdateStudent();
            if (StudentChanged!=null) {
                StudentChanged(this, EventArgs.Empty);
            }
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) {
            Close();
        }
    }
}
