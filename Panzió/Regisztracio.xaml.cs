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

namespace Panzió
{
    /// <summary>
    /// Interaction logic for Regisztracio.xaml
    /// </summary>
    public partial class Regisztracio : Window
    {
        List<Ugyfel> ugyfelList=new List<Ugyfel>();
        public Regisztracio()
        {
            InitializeComponent();
            dgrracs2.ItemsSource = ugyfelList;
        }

      
        private void elozo_Click(object sender, RoutedEventArgs e)
        {
            if (ugyfelnev.Text == string.Empty)
            {
                MessageBox.Show("Adjon meg egy nevet!");
            }
            else if (ugyfelaz.Text == string.Empty)
            {
                MessageBox.Show("Adjon meg egy azonosítót!");
            }
            else if (email.Text == string.Empty)
            {
                MessageBox.Show("Adjon meg egy emailt!");
            }
            else if (birth.Text == string.Empty)
            {
                MessageBox.Show("Adjon meg egy születésdátumot!");
            }
            else
            {
                ugyfelList.Add(new Ugyfel(ugyfelnev.Text, ugyfelaz.Text, email.Text, VIPkod.Text, DateTime.Parse(birth.Text), yes.IsChecked.Value));
                dgrracs2.Items.Refresh();
            }


        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            yes.IsChecked = yes.IsChecked;
        }
        private void vissza_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       
    }
}
