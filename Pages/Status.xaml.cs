using Microsoft.Win32;
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
    /// Логика взаимодействия для Status.xaml
    /// </summary>
    public partial class Status : Page
    {
        public Status()
        {
            InitializeComponent();
        }

        private void ChooseImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg;*.pdf)|*.png;*.jpeg;*.jpg;*.pdf|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Выберите файл документа";

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

        private void Next(object sender, RoutedEventArgs e)
        {
            if (child.IsChecked == true || inval.IsChecked == true || malob.IsChecked == true)
            {
                if (nothave.IsChecked == true || have.IsChecked == true)
                {
                    if (have.IsChecked == true)
                    {
                        if (string.IsNullOrEmpty(Link.Text))
                        {
                            MessageBox.Show("При выборе 'Имею' необходимо прикрепить сканы документа!");
                            return;
                        }

                        if (!System.IO.File.Exists(Link.Text))
                        {
                            MessageBox.Show("Выбранный файл не существует!");
                            return;
                        }
                    }

                    NavigationService.Navigate(new Speciality());
                }
                else
                {
                    MessageBox.Show("Имеешь ли ты приписное удостоверение?");
                }
            }
            else
            {
                MessageBox.Show("Выбери свой статус!");
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
