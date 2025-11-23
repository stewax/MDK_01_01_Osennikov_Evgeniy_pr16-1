using Submission_of_Applications_Осенников.RegexC;
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
    /// Логика взаимодействия для Statement.xaml
    /// </summary>
    public partial class Statement : Page
    {
        public Statement()
        {
            InitializeComponent();
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(OrganizationName.Text) && Check.CheckReg(OrganizationName.Text, "^[А-Яа-яЁё0-9., ]*$"))
            {
                if (!string.IsNullOrEmpty(OrganizationLastDate.Text) && Check.CheckReg(OrganizationLastDate.Text, "^\\d{4}$"))
                {
                    if (Ochno.IsChecked == true || Zaochno.IsChecked == true)
                    {
                        if (Budjet.IsChecked == true || Pay.IsChecked == true)
                        {
                            NavigationService.Navigate(new Education());
                        }
                        else
                        {
                            MessageBox.Show("Выберите стоимость обучения!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выберите форму обучения!");
                    }
                }
                else
                {
                    MessageBox.Show("Неправильно введен год окончания!");
                }
            }
            else
            {
                MessageBox.Show("Неправильно введено образовательное учереждение!");
            }
        }
    }
}
