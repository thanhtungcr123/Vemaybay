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

namespace veMayBay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double Tong = 0;
        string sex, ve, tien, nuoc;
        bool sale ;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedType = (nationality.SelectedItem as ListBoxItem);
            switch (selectedType.Content.ToString())
            {
                case "vietnam":
                    sale = true;
                    break;
                case "france":
                    sale = false;
                    break;
                case "england":
                    sale = false;                  
                    break;
                case "canada":                   
                    sale = false;                   
                    break;
            }

            nuoc = selectedType.Content.ToString();
        }

        private void male_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)male.IsChecked)
            {
                sex = male.Content.ToString();
                female.IsEnabled = false;
            }
        }

        private void female_Checked(object sender, RoutedEventArgs e)
        {
            if((bool)female.IsChecked)
            {
                sex = female.Content.ToString();
                male.IsEnabled = false;
            }
        }

        private void bed_Checked(object sender, RoutedEventArgs e)
        {
            if((bool)bed.IsChecked)
            {
                ve = bed.Content.ToString();
                Tong += 500000;
                chair.IsEnabled = false;
            }
        }

        private void chair_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)chair.IsChecked)
            {
                ve = chair.Content.ToString();
                Tong += 200000;
                bed.IsEnabled = false;
            }
        }

        private void VND_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)vnd.IsChecked)
            {
                tien = vnd.Content.ToString();
                usd.IsEnabled = false;
            }
        }

        private void USD_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)usd.IsChecked)
            {
                tien = usd.Content.ToString();
                Tong /= 20000;
                vnd.IsEnabled = false;
            }
        }

        private void TicketBoking_Click(object sender, RoutedEventArgs e)
        {
            if (sale == true)
                Tong *= 0.8;
            
            MessageBox.Show("Name: " + name.Text + "\nPhone: " + phone.Text + "\nSex: " + sex + "\nNationnality: " + nuoc + "\nTicket Type: " + ve + "\nPay: " + tien + "\nMoney: " + Tong);
        }


    }
}
