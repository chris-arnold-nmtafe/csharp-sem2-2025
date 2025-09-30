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
    /// Interaction logic for StudentPalette.xaml
    /// </summary>
    public partial class StudentPalette : UserControl
    {
        private Student student;
        internal Student Student { 
            get {  return student; }
            set {
                student = value;
                givenName.Text = student.FirstName;
                familyName.Text = student.LastName;
                comboEnrolment.SelectedItem = student.Enrolment;
            }
        }
        public StudentPalette()
        {
            student = new Student();
            InitializeComponent();
            comboEnrolment.ItemsSource = Enum.GetValues(typeof(EnrolmentStatus));
        }

        internal Student UpdateStudent() {
            student.FirstName = givenName.Text;
            student.LastName = familyName.Text;
            return student;
        }

        private void comboEnrolment_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            student.Enrolment = (EnrolmentStatus)comboEnrolment.SelectedItem;
            if (StudentChanged != null) {
                StudentChanged(this, new EventArgs());
            }
        }

        public event EventHandler StudentChanged;
    }
}
