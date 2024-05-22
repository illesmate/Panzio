using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace Panzió
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Szobak> panziList =new List<Szobak>();
        public MainWindow()
        {
            InitializeComponent();
            Szobakszama.Items.Add("1");
            Szobakszama.Items.Add("2");
            Szobakszama.Items.Add("3");
            Szobakszama.Items.Add("4");
            Szobakszama.Items.Add("5");
            Szobakszama.Items.Add("6");
            dgrracs.ItemsSource = panziList;
        }

        private void Foglal_Click(object sender, RoutedEventArgs e)
        {
            panziList.Add(new Szobak(int.Parse(Szobakszama.Text), int.Parse(hely.Text), int.Parse(ar.Text)));
            dgrracs.Items.Refresh();
           
        }

        private void adatfelvitel_Click(object sender, RoutedEventArgs e)
        {
            Regisztracio ujBevitel =  new Regisztracio();
            ujBevitel.ShowDialog();
            dgrracs.Items.Refresh();
        }


        private void hely_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Szobakszama.SelectedIndex ==2)
            {
                
                hely.Text ="2";
                ar.Text = "6000";
               
                
            }
           else if (Szobakszama.SelectedIndex == 3)
            {
                hely.Text = "3";
                ar.Text = "6000";
            }
            else if (Szobakszama.SelectedIndex == 1)
            {
                hely.Text = "2";
                ar.Text = "6000";
            }
            else if (Szobakszama.SelectedIndex == 4)
            {
                hely.Text = "2";
                ar.Text = "12000";
            }
            else if (Szobakszama.SelectedIndex == 5)
            {
                hely.Text = "3";
                ar.Text = "12000";
            }
            else if (Szobakszama.SelectedIndex == 0)
            {
                hely.Text = "4";
                ar.Text = "12000";
            }
        }
    }
}
