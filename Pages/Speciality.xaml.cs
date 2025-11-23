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

namespace Submission_of_Applications_Осенников.Pages
{
    /// <summary>
    /// Логика взаимодействия для Speciality.xaml
    /// </summary>
    public partial class Speciality : Page
    {
        public Speciality()
        {
            InitializeComponent();
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            if (one.IsChecked == true || two.IsChecked == true || three.IsChecked == true || four.IsChecked == true ||
                five.IsChecked == true || six.IsChecked == true || seven.IsChecked == true || eight.IsChecked == true ||
                nine.IsChecked == true || ten.IsChecked == true || eleven.IsChecked == true || twelve.IsChecked == true ||
                thirteen.IsChecked == true)
            {
                if (first.IsChecked == true || notfirst.IsChecked == true)
                {
                    if (confone.IsChecked == true && conftwo.IsChecked == true)
                    {
                        NavigationService.Navigate(new Passport());
                    }
                    else
                    {
                        MessageBox.Show("Подтвердите что ознакомлены с документами!");
                    }
                }
                else
                {
                    MessageBox.Show("Впервые ли получаете среднее профессиональное образование?");
                }
            }
            else
            {
                MessageBox.Show("Выберите хотя бы одну специальность!");
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
