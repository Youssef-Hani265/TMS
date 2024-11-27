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

namespace TaskApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TaskDBEntities db = new TaskDBEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, RoutedEventArgs e)
        {
            var admin = db.Users.FirstOrDefault(u => u.UserName == nametxt.Text && u.UserPass == passtxt.Password && u.Role == "admin");
            var user = db.Users.FirstOrDefault(u => u.UserName == nametxt.Text && u.UserPass == passtxt.Password && u.Role == "user");
            if (admin != null)
            {
                MessageBox.Show("Welcome Admin");
                adminPage page1 = new adminPage();
                page1.Show();
                this.Close();
            }
            else if (user != null)
            {
                MessageBox.Show("Welcome Employee");
                UserPage page2 = new UserPage();
                page2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("invalid Login");
            }
        }
    }
}
