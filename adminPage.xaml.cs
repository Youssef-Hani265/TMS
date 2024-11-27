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
    /// Interaction logic for adminPage.xaml
    /// </summary>
    public partial class adminPage : Window
    {
        TaskDBEntities db = new TaskDBEntities();
        public adminPage()
        {
            InitializeComponent();
            LoadData();
            Clear();
        }
        public void LoadData()
        {
            AdminGrid.ItemsSource = db.Tasks.ToList();
        }

        public void Clear()
        {
            idtxt.Text = "";
            titletxt.Text = "";
            desctxt.Text = "";
            cb.Text = "";
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            var task = new Task
            {
                TaskID = int.Parse(idtxt.Text),
                TaskTitle = titletxt.Text,
                Description = desctxt.Text,
                Status = cb.Text,
                DueDate = DateTime.Now,
                
            };
            db.Tasks.Add(task);
            db.SaveChanges();
            LoadData();
            Clear();
        }


        private void Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            if (AdminGrid.SelectedItem is Task _selected)
            {
                _selected.TaskID = int.Parse(idtxt.Text);
                _selected.TaskTitle = titletxt.Text;
                _selected.Description = desctxt.Text;
                _selected.Status = cb.Text;
               
                db.SaveChanges();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select task to Update");
            }
            Clear();
        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
            if (AdminGrid.SelectedItem is Task _selected)
            {
                _selected.TaskID = int.Parse(idtxt.Text);
                _selected.TaskTitle = titletxt.Text;
                _selected.Description = desctxt.Text;
                _selected.Status = cb.Text;
                db.Tasks.Remove(_selected);
                db.SaveChanges();
                LoadData();
            }
            else
            {
                MessageBox.Show("please select task to delete");
            }
            

        }

        private void AdminGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AdminGrid.SelectedItem is Task _selected)
            {
                idtxt.Text = _selected.TaskID.ToString();
                titletxt.Text = _selected.TaskTitle.ToString();
                desctxt.Text = _selected.Description;
                cb.Text = _selected.Status;
            }
        }
    }
}
