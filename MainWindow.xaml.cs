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

namespace Revision
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SchoolDBEntities2 DB = new SchoolDBEntities2();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
          
            var User = DB.Classes.FirstOrDefault(U => U.CName == txtName.Text  && U.Password == int.Parse(txtPass.Text));
            if (User != null)
            {
                MessageBox.Show("Welcome!");
                Crud crud = new Crud();
                crud.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Refill the data correctly!");
            }
        }
    }
}
