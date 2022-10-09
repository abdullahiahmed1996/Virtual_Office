using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Virtual_Office
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        enum Departments
        {
            Finances,
            Administration,
            Production,
            Marketing
        }

        private void InitializeComboBox()
        {
            foreach (var item in Enum.GetValues(typeof(Departments)))
            {
                cbDepartment.Items.Add(item);   
            }

        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Kolla att alla fält är ifyllda
            // Skapa en ny employee

            // Skicka den emplyee:n till ListView

            if(txtFirstName.Text.Length > 0)
            {
                // Skapa en ny employee

                Employee employee = new();
                employee.FirstName = txtFirstName.Text;
                employee.LastName = txtSecondName.Text;
                employee.Department = cbDepartment.Text;

                // TODO assign more properties



                // Skicka den employeen till ListView
                ListViewItem item = new();

                item.Content = employee.GetInfo();
                item.Tag = employee;

                lvFullname.Items.Add(item);

                
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            //foreach (ListViewItem item in lvFullname.Items)
            //{

            //}

            foreach(ListViewItem itemSelected in lvFullname.SelectedItems)
            {
                lvFullname.Items.Remove(itemSelected);
            }
        }


    }
}

