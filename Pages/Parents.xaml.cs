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
    /// Логика взаимодействия для Parents.xaml
    /// </summary>
    public partial class Parents : Page
    {
        public Parents()
        {
            InitializeComponent();
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            bool momFilled = !string.IsNullOrEmpty(tb_FIOMom.Text);
            bool dadFilled = !string.IsNullOrEmpty(tb_FIODad.Text);

            if (!momFilled && !dadFilled)
            {
                MessageBox.Show("Заполните данные хотя бы для одного родителя!");
                return;
            }

            if (momFilled)
            {
                if (!Check.CheckReg(tb_FIOMom.Text, "^[А-ЯЁ][а-яё]*[ ][А-ЯЁ][а-яё]*[ ][А-ЯЁ][а-яё]*$"))
                {
                    MessageBox.Show("Введите корректное ФИО матери!");
                    return;
                }
                if (!Check.CheckReg(tb_DateofBirthMom.Text, "^\\d{2}[.]\\d{2}[.]\\d{4}$"))
                {
                    MessageBox.Show("Введите дату рождения матери!");
                    return;
                }
                if (string.IsNullOrEmpty(tb_PlaceWorkMom.Text) || !Check.CheckReg(tb_PlaceWorkMom.Text, "^[А-Яа-яЁё0-9.\\-, ]*$"))
                {
                    MessageBox.Show("Введите место работы матери!");
                    return;
                }
                if (string.IsNullOrEmpty(tb_StelleMom.Text) || !Check.CheckReg(tb_StelleMom.Text, "^[А-Яа-яA-Za-z\\s\\-]+$"))
                {
                    MessageBox.Show("Введите должность матери!");
                    return;
                }
                if (string.IsNullOrEmpty(tb_PlaceLiveMom.Text) || !Check.CheckReg(tb_PlaceLiveMom.Text, "^[А-Яа-яЁё0-9.\\-, ]*$"))
                {
                    MessageBox.Show("Введите место жительства матери!");
                    return;
                }
                if (string.IsNullOrEmpty(tb_HomeNumberMom.Text) || !Check.CheckReg(tb_HomeNumberMom.Text, "^(\\+7)\\d{10}$"))
                {
                    MessageBox.Show("Введите корректный домашний телефон матери!");
                    return;
                }
                if (string.IsNullOrEmpty(tb_MobileNumberMom.Text) || !Check.CheckReg(tb_MobileNumberMom.Text, "^(\\+7)\\d{10}$"))
                {
                    MessageBox.Show("Введите корректный мобильный телефон матери!");
                    return;
                }
                if (ConfirmMom.IsChecked != true)
                {
                    MessageBox.Show("Подтвердите данные матери!");
                    return;
                }
            }

            if (dadFilled)
            {
                if (!Check.CheckReg(tb_FIODad.Text, "^[А-ЯЁ][а-яё]*[ ][А-ЯЁ][а-яё]*[ ][А-ЯЁ][а-яё]*$"))
                {
                    MessageBox.Show("Введите корректное ФИО отца!");
                    return;
                }
                if (!Check.CheckReg(tb_DateofBirthDad.Text, "^\\d{2}[.]\\d{2}[.]\\d{4}$"))
                {
                    MessageBox.Show("Введите дату рождения отца!");
                    return;
                }
                if (string.IsNullOrEmpty(tb_PlaceWorkDad.Text) || !Check.CheckReg(tb_PlaceWorkDad.Text, "^[А-Яа-яЁё0-9.\\-, ]*$"))
                {
                    MessageBox.Show("Введите место работы отца!");
                    return;
                }
                if (string.IsNullOrEmpty(tb_StelleDad.Text) || !Check.CheckReg(tb_StelleDad.Text, "^[А-Яа-яA-Za-z\\s\\-]+$"))
                {
                    MessageBox.Show("Введите должность отца!");
                    return;
                }
                if (string.IsNullOrEmpty(tb_PlaceLiveDad.Text) || !Check.CheckReg(tb_PlaceLiveDad.Text, "^[А-Яа-яЁё0-9.\\-, ]*$"))
                {
                    MessageBox.Show("Введите место жительства отца!");
                    return;
                }
                if (string.IsNullOrEmpty(tb_HomeNumberDad.Text) || !Check.CheckReg(tb_HomeNumberDad.Text, "^(\\+7)\\d{10}$"))
                {
                    MessageBox.Show("Введите корректный домашний телефон отца!");
                    return;
                }
                if (string.IsNullOrEmpty(tb_MobileNumberDad.Text) || !Check.CheckReg(tb_MobileNumberDad.Text, "^(\\+7)\\d{10}$"))
                {
                    MessageBox.Show("Введите корректный мобильный телефон отца!");
                    return;
                }
                if (ConfirmDad.IsChecked != true)
                {
                    MessageBox.Show("Подтвердите данные отца!");
                    return;
                }
            }
            MainWindow.Instance.Close();

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
