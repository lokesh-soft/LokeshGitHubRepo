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

namespace myDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Create a new emploee record
            //Instantiate a new emploee object and give information

            Employee paddyRiordan = new Employee();
            paddyRiordan.employeeID = " 001";
            paddyRiordan.employeeName = "   paddy Riordan";
            paddyRiordan.employeeAddress = "    Co. Fermanagh";
            paddyRiordan.employeeCity = "   Enniskillen";
            paddyRiordan.employeeState = "  Kesh";
            DataGridXAML.Items.Add(paddyRiordan);

            Employee voiletRiordan = new Employee();
            voiletRiordan.employeeID = " 002";
            voiletRiordan.employeeName = "   voilet Riordan";
            voiletRiordan.employeeAddress = "    Co. Fermanagh";
            voiletRiordan.employeeCity = "   Enniskillen";
            voiletRiordan.employeeState = "  Kesh";
            DataGridXAML.Items.Add(voiletRiordan);
        }

        public class Employee
        {
            public string employeeID { get; set; }
            public string employeeName { get; set; }
            public string employeeAddress { get; set; }
            public string employeeCity { get; set; }
            public string employeeState { get; set; }
        }

        private void AddNewEmployeeBN_Clicked(object sender, RoutedEventArgs e)
        {
            Employee tempEmployee = new Employee();
            tempEmployee.employeeID = IDTB.Text;
            tempEmployee.employeeName = NameTB.Text;
            tempEmployee.employeeAddress = AddressTB.Text;
            tempEmployee.employeeCity = CityTB.Text;
            tempEmployee.employeeState = StateTB.Text;
            DataGridXAML.Items.Add(tempEmployee);
        }
    }
}
