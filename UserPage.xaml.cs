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

namespace TaskApp
{
    /// <summary>
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Window
    {
        TaskDBEntities db = new TaskDBEntities();
        public UserPage()
        {
            InitializeComponent();
            load1();
            load2();
            
        }
        public void load1()
        {
            pindingGrid.ItemsSource = db.Tasks.Where(s => s.Status == "pending" || s.Status == "in progress" ).ToList();
        }
        public void load2()
        {
            completedGrid.ItemsSource = db.Tasks.Where(m => m.Status == "completed").ToList();
        }
        


        private void savebtn_Click(object sender, RoutedEventArgs e)
        {
            if (pindingGrid.SelectedItem is Task _selected)
            {
                _selected.TaskID = int.Parse(empidtxt.Text);
                _selected.Status = comp.Text;
                db.SaveChanges();
                load1();
                load2();
            }
            
           

        }

        private void pindingGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (pindingGrid.SelectedItem is Task _selected)
            {
                empidtxt.Text = _selected.TaskID.ToString();
                comp.Text = _selected.Status;
            }
        }
    }
}
