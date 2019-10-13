using System;
using System.Collections.Generic;
using System.Data;
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

namespace money_tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataTable table = new DataTable();
            table.Columns.Add("Forename", typeof(string));
            table.Columns.Add("Surname", typeof(string));
            table.Columns.Add("Age", typeof(int));
            DataRow row = table.NewRow();
            row["Forename"] = "John";
            row["Surname"] = "Gould";
            row["Age"] = 28;
            table.Rows.Add(row);
            myTable.DataContext = table;
        }
    }
}
