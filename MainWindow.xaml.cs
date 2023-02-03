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

namespace Lecture_Example___Selection_Box___ListBox_and_Combo_Box__
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        List <Student> students= new List<Student>();
       Student selectedStudent = null;
        public MainWindow()
        {
            InitializeComponent();
            Preload();
            DisplayToListbox();
            DisplayToCombobox();

        }

        private void btAddToList_Click(object sender, RoutedEventArgs e)
        {
            string userInput = tbToAdd.Text;
            lbDisplay.Items.Add(userInput);
           
        }
        public void Preload()
        {
            students.Add(new Student("Will", "Cram", 100, 102));
            students.Add(new Student("Finley", "Deck", 120, 112));
            students.Add(new Student("Sasha", "Gram", 90, 114));
            students.Add(new Student("Carson", "Luim", 130, 100));
            students.Add(new Student("Jennifer", "Mill", 99, 102));
        }
        public void DisplayToListbox()
        {
            lbDisplay.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                lbDisplay.Items.Add(students[i]);
            }
        
        }
        public void DisplayToCombobox()
        {
            cbDisplay.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {

               cbDisplay.Items.Add(students[i]);

            }

        }

        private void btnDisplaySelectedStu_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = lbDisplay.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("Please Select a Name from List Box");
            }
            else 
            {
                selectedStudent = students[selectedIndex];
                DisplayStudentInformation(selectedStudent);

            }
        }
        public void DisplayStudentInformation(Student student)
        {
            tbFirstName.Text = student.FirstName;
            tbLastName.Text = student.LastName;
            tbCSIGrade.Text = student.CSIGrade.ToString();
            tbGenEdGrade.Text = student.GenEdGrade.ToString();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            string fName = tbFirstName.Text;
            string lName = tbLastName.Text;
            int csi = int.Parse(tbCSIGrade.Text);
            int gened = int.Parse(tbGenEdGrade.Text);

            Student newStudent = new Student(fName,lName, csi, gened);
            students.Add(newStudent);
            DisplayToListbox();
            DisplayToCombobox();
        }

        private void btnRemoveSelectedStudent_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = lbDisplay.SelectedIndex;
            selectedStudent = students[selectedIndex];
            students.Remove(selectedStudent);

            DisplayToListbox();
            DisplayToCombobox();
        }

    }
}
