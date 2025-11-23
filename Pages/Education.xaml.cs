using Microsoft.Win32;
using Submission_of_Applications_Осенников.RegexC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
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
    /// Логика взаимодействия для Education.xaml
    /// </summary>
    public partial class Education : Page
    {
        public Education()
        {
            InitializeComponent();
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            if (nine_class.IsChecked == true || eleven_class.IsChecked == true || SPO.IsChecked == true || VPO.IsChecked == true)
            {
                if (Atestat.IsChecked == true || Diplom.IsChecked == true)
                {
                    if (!string.IsNullOrEmpty(SerialAndNumberEduc.Text) && Check.CheckReg(SerialAndNumberEduc.Text, "^(\\d{14}|\\d{9}[-]\\d{7})$"))
                    {
                        if (!string.IsNullOrEmpty(AvgScore.Text) && Check.CheckReg(AvgScore.Text, "^\\d{1}[,.]\\d{2}$"))
                        {
                            if (string.IsNullOrEmpty(Link.Text))
                            {
                                MessageBox.Show("Необходимо прикрепить сканы документа об образовании!");
                                return;
                            }

                            if (!File.Exists(Link.Text))
                            {
                                MessageBox.Show("Выбранный файл не существует!");
                                return;
                            }

                            NavigationService.Navigate(new Status());
                        }
                        else
                        {
                            MessageBox.Show("Неправильно введён средний балл!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильно введён номер и серия атестатта (диплома)!");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите аттестат или диплом!");
                }
            }
            else
            {
                MessageBox.Show("Выберите оконченное образование!");
            }
        }

        private void ChooseImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg;*.pdf)|*.png;*.jpeg;*.jpg;*.pdf|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Выберите файл документа об образовании";

            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFile = openFileDialog.FileName;

                string extension = System.IO.Path.GetExtension(selectedFile).ToLower();
                if (extension != ".png" && extension != ".jpeg" && extension != ".jpg" && extension != ".pdf")
                {
                    MessageBox.Show("Неподдерживаемый формат файла. Выберите файл в формате PNG, JPEG, JPG или PDF.");
                    return;
                }

                Link.Text = selectedFile;
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
